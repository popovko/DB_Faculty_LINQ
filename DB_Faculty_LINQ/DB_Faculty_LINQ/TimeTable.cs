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
    public partial class TimeTable : Form
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);

        private void fillTT()
        {
            const int countLessinWeek = 20;
            dgvtt.ColumnCount = 1;
            dgvtt.RowCount = countLessinWeek;
            dgvtt.TopLeftHeaderCell.Value = "День тижня";
            dgvtt.Columns[0].HeaderCell.Value = "Номер пари";
            dgvtt.Rows[0].HeaderCell.Value = "Понеділок";
            dgvtt.Rows[4].HeaderCell.Value = "Вівторок";
            dgvtt.Rows[8].HeaderCell.Value = "Середа";
            dgvtt.Rows[12].HeaderCell.Value = "Четвер";
            dgvtt.Rows[16].HeaderCell.Value = "П'ятниця";

            for(int i=0; i< countLessinWeek; i++)
            {
                dgvtt.Rows[i].Cells[0].Value = i % 4 + 1;//1 2 3 4, 1 2 3 4...
            }
            //заповнюємо групи
            var groups = from g in db.GetTable<Group>()
                         orderby g.gr_year
                         select g;
            foreach(var group in groups)
            {
                dgvtt.ColumnCount++;
                dgvtt.Columns[dgvtt.ColumnCount-1].HeaderCell.Value = group.gr_name;

            }      

            foreach(DataGridViewColumn col in dgvtt.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           
            var lessons = from l in db.GetTable<Lesson>()
                          select l;
         
            foreach(var lesson in lessons)
            {
                var grls = from gl in db.GetTable<LessonGroup>()
                           where gl.lsgr_lsID == lesson.ls_ID
                           select gl.lsgr_grID;
                List<int> listIdgrInLes = grls.ToList();

                var tcls = from tl in db.GetTable<LessonTeacher>()
                           where tl.lstc_lsID == lesson.ls_ID
                           select new
                           {
                               aud = tl.lstc_aud,
                               tcid = tl.lstc_tcID
                           };
                foreach(var id in grls)
                {
                    for(int i=0; i<dgvtt.ColumnCount-1; i++)
                    {
                        if(Helper.NameGrFromIdGr(id) == dgvtt.Columns[i].HeaderText)
                        {
                            int currRow =  Helper.numDOW(lesson.ls_DOW) + lesson.ls_num - 1;
                            dgvtt.Rows[currRow].Cells[i].Value = Helper.DelSpase( Helper.NameSbFromIDSb(lesson.ls_sbID) ) ;
                            //dgvtt.Rows[0].Cells[i].Value = Helper.NameSbFromIDSb(lesson.ls_sbID);
                            foreach (var teacher in tcls)
                            {
                                dgvtt.Rows[currRow].Cells[i].Value += Helper.DelSpase(Helper.NameTcFromIdTc(teacher.tcid)) + "\r\n";
                                dgvtt.Rows[currRow].Cells[i].Value += teacher.aud.ToString() + "\r\n";
                            }
                        }
                    }
                }

            }

            
            

        }

        public TimeTable()
        {
            InitializeComponent();
            fillTT();

        }
    }
}
