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
using System.Data.SqlTypes;

namespace DB_Faculty_LINQ
{
    public partial class AddGroup : Form
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);


        public AddGroup()
        {
            //заповнюємо бокси
            InitializeComponent();
            object[] years = new object[] { 1, 2, 3, 4, 5, 6 };
            cbGrYear.Items.AddRange(years);

            var tc = from t in db.GetTable<Teacher>()
                     select t.tc_name;
            foreach (var teacher in tc)
            {
                cbCurator.Items.Add(teacher);
            }

            var dp = from d in db.GetTable<Department>()
                     select d.dp_name;

            foreach (var depatrment in dp)
            {
                cbDp.Items.Add(depatrment);
            }

            cbCurator.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrYear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void AddCurator(string nameTc, string nameGr)
        {
            var tc = from t in db.GetTable<Teacher>()
                     where t.tc_name == nameTc
                     select t.tc_ID;
            var gr = from g in db.GetTable<Group>()
                     where g.gr_name == nameGr
                     select g.gr_ID;
            Curator curator = new Curator { cr_tcID = tc.ToList()[0], cr_grID = gr.ToList()[0] };
            db.GetTable<Curator>().InsertOnSubmit(curator);
            db.SubmitChanges();
        }

        private void cbCurator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!tbCurators.Text.Contains(cbCurator.Text))
            {
                tbCurators.Text += (cbCurator.Text + ",");
            }
                
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var dpid = from d in db.GetTable<Department>()
                           where d.dp_name == cbDp.Text
                           select d.dp_ID;

                //перевіряємо чи користувач вибрав кафедру і надаємо значення відповідній групі
                int? idornull = null;
                if (dpid.ToList().Count != 0)
                    idornull = dpid.ToList()[0];

                Group group = new Group() { gr_name = tbGrName.Text, gr_year = Convert.ToInt32(cbGrYear.Text),
                    gr_dpID = idornull, gr_leader = null};

                db.GetTable<Group>().InsertOnSubmit(group);
                db.SubmitChanges();

                // ідема по викладачам і назначаємо їх кураторами
                string nameTc = "";
                for(int i=0; i<tbCurators.Text.Length; i++)
                {
                    if (tbCurators.Text[i] == ',')
                    {
                        AddCurator(nameTc, tbGrName.Text);
                        nameTc = "";
                        continue;
                    }
                        
                    if(tbCurators.Text[i]!=' ')
                    {
                        nameTc += tbCurators.Text[i];
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
