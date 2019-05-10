using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.Linq;


namespace DB_Faculty_LINQ
{
    public partial class AddLesson : Form
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);
            
        public AddLesson()
        {
            InitializeComponent();
            // блокуємо ручне редагування комбо боксів
            cbGr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDOW.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLsNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTc.DropDownStyle = ComboBoxStyle.DropDownList;

            //заповнюємо комбо бокси
            var sb = from s in db.GetTable<Subject>()
                     select s.sb_name;
            foreach(var sub in sb)
            {
                cbSb.Items.Add(sub);
            }

            string[] DOWs = new string[] { "Понедідок", "Вівторок","Середа","Четвер","П'ятниця" };
            cbDOW.Items.AddRange(DOWs);
            cbLsNum.Items.AddRange(new object[] { 1, 2, 3, 4 });

            var gr = from g in db.GetTable<Group>()
                     select g.gr_name;

            foreach(var gru in gr)
            {
                cbGr.Items.Add(gru);
            }

            var tc = from t in db.GetTable<Teacher>()
                     select t.tc_name;

            foreach(var teac in tc)
            {
                cbTc.Items.Add(teac);
            }
        }

        public void CheckLsGr(int grID, int lsID)
        {
            var lsgr = from lg in db.GetTable<LessonGroup>()
                       where lg.lsgr_grID == grID
                       select lg.lsgr_lsID;


            foreach(var lesgro in lsgr)
            {
                if (Helper.NumLsFromIDLs(lesgro) == Helper.NumLsFromIDLs(lsID) &&
                    Helper.DOWLsFromIDLs(lesgro) == Helper.DOWLsFromIDLs(lsID))
                    throw new Exception("Група " + Helper.NameGrFromIdGr(grID) + "зайнята в цей час"); 
            }
        }

        public void AddLessonGroup(int grID, int lsID)
        {
            CheckLsGr(grID, lsID);
            LessonGroup lessonGroup = new LessonGroup { lsgr_grID = grID, lsgr_lsID = lsID };
            db.GetTable<LessonGroup>().InsertOnSubmit(lessonGroup);
        }

        public void CheckLsTc(int tcID, int aud, int lsID)
        {
            var lstc = from lt in db.GetTable<LessonTeacher>()
                       where lt.lstc_tcID == tcID
                       select lt.lstc_lsID;

            foreach(var lesteach in lstc)
            {
                if (Helper.NumLsFromIDLs(lesteach) == Helper.NumLsFromIDLs(lsID) &&
                    Helper.DOWLsFromIDLs(lesteach) == Helper.DOWLsFromIDLs(lsID))
                    throw new Exception("Викладач " + Helper.NameTcFromIdTc(tcID) + "зайнятий в цей час");
            }
        }

        public void AddLessonTeacher(int tcID, int aud, int lsID)
        {
            CheckLsTc(tcID, aud, lsID);
            LessonTeacher lessonTeacher = new LessonTeacher { lstc_aud = aud, lstc_lsID = lsID, lstc_tcID = tcID };
            db.GetTable<LessonTeacher>().InsertOnSubmit(lessonTeacher);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int thisLsId = 0;

            try
            {
                //додаємо в базу
                Lesson lesson = new Lesson { ls_sbID = Helper.IDsbFromNameSb(cbSb.Text), ls_DOW = cbDOW.Text, ls_num = Convert.ToInt32(cbLsNum.Text) };
                db.GetTable<Lesson>().InsertOnSubmit(lesson);
                db.SubmitChanges();

                //сортуємо по спаданню айді і вибираємо перший елемент - остання додана пара
                var ls = from l in db.GetTable<Lesson>()
                         orderby -l.ls_ID
                         select l.ls_ID;

                thisLsId = ls.ToList()[0];

                string nameGr = "";

                //Додаємо лесонгрупи
                for(int i=0; i< tbGr.Text.Length; i++)
                {
                    if(tbGr.Text[i] == ',')
                    {
                        AddLessonGroup(Helper.IDgrFromNameGr(nameGr), thisLsId);
                        nameGr = "";
                        continue;
                    }

                    if(tbGr.Text[i] != ' ')
                    {
                        nameGr += tbGr.Text[i];
                    }
                }

                int aud = 0;
                string nameTc = "";
                bool IsNameNow = true;

                // домаєно лесонтічери
                for (int i = 0; i < tbTcAud.Text.Length; i++)
                {
                    if (tbTcAud.Text[i] == ',')
                    {
                        AddLessonTeacher(Helper.IdTcFromNameTc(nameTc), aud, thisLsId);
                        nameTc = "";
                        aud = 0;
                        IsNameNow = true;
                        continue;
                    }

                    if(tbTcAud.Text[i] == '+')
                    {
                        IsNameNow = false;
                    }

                    if (tbTcAud.Text[i] != ' ' && tbTcAud.Text[i] != '+')
                    {
                        if (IsNameNow)
                            nameTc += tbTcAud.Text[i];
                        else
                            aud = aud * 10 + (tbTcAud.Text[i] - '0');
                    }
                }

            }
            catch(Exception ex)
            {             
                MessageBox.Show(ex.Message);
                if(thisLsId!=0)
                {
                    var ls = from l in db.GetTable<Lesson>()
                             where l.ls_ID == thisLsId
                             select l;
                    db.GetTable<Lesson>().DeleteOnSubmit(ls.FirstOrDefault());
                    db.SubmitChanges();
                }
                    
                return;
            }
            db.SubmitChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!tbGr.Text.Contains(cbGr.Text))
              tbGr.Text += cbGr.Text + ',';
        }

        private void cbTc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTcAud.Text += cbTc.Text + "+,";
            tbTcAud.SelectionStart = tbTcAud.Text.Length - 1;
            tbTcAud.Text = Helper.DelSpase(tbTcAud.Text);
        }

        private void btnGrClean_Click(object sender, EventArgs e)
        {
            tbGr.Clear();
        }

        private void btnTcAudClean_Click(object sender, EventArgs e)
        {
            tbTcAud.Clear();
        }
    }
}
