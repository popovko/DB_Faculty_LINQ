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
    public partial class MainForm : Form
    {
        public static string connectionStr = "Data Source=DESKTOP-V0OV6R9;Initial Catalog=newFaculty;Integrated Security=True";

        public MainForm()
        {

            InitializeComponent();

            //combo box pushing
            string[] tableNames = { "Студент", "Група", "Викладач", "Кафедра", "Предмет", "Куратор"};
            cbTables.Items.AddRange(tableNames);

        }


        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionStr);
            dgv.ColumnCount = 0;
            dgv.RowCount = 1;
            int i = 0;
            switch (cbTables.Text)
            {
                
                case "Студент":

                    var stAndGr = (from st in db.GetTable<Student>()
                                   join gr in db.GetTable<Group>() on st.st_grID equals gr.gr_ID
                                   select new
                                   {
                                       stname = st.st_name,
                                       grname = gr.gr_name

                                   });

                    dgv.ColumnCount = 2;
                    i = 0;
                    dgv.RowCount = stAndGr.Count() + 1;
                    foreach (var st in stAndGr)
                    {
                        dgv.Rows[i].Cells[0].Value = st.stname;
                        dgv.Rows[i].Cells[1].Value = st.grname;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Ім'я";
                    dgv.Columns[1].HeaderCell.Value = "Група";
                    break;

                case "Кафедра":
                    var dpfAndch = (from dp in db.GetTable<Department>()
                                    join tc in db.GetTable<Teacher>()
                                    on dp.dp_chief equals tc.tc_ID into a
                                    from b in a.DefaultIfEmpty()
                                    select new
                                    {
                                        dpname = dp.dp_name,
                                        chief = b.tc_name ?? ""
                                    });
                    dgv.ColumnCount = 2;
                    i = 0;
                    dgv.RowCount = dpfAndch.Count() + 1;
                    foreach (var dp in dpfAndch)
                    {
                        dgv.Rows[i].Cells[0].Value = dp.dpname;
                        dgv.Rows[i].Cells[1].Value = dp.chief;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Кафедра";
                    dgv.Columns[1].HeaderCell.Value = "Шеф";
                    break;

                case "Група":
                    var grAndStAndDp = (from gr in db.GetTable<Group>()
                                        join st in db.GetTable<Student>()
                                        on gr.gr_leader equals st.st_ID into a
                                        from b in a.DefaultIfEmpty()
                                        join dp in db.GetTable<Department>()
                                        on gr.gr_dpID equals dp.dp_ID into c
                                        from d in c.DefaultIfEmpty()
                                        select new
                                        {
                                            grname = gr.gr_name,
                                            gryear = gr.gr_year,
                                            grdp = d.dp_name ?? "",
                                            grleader = b.st_name ?? ""
                                        });
                    dgv.ColumnCount = 4;
                    i = 0;
                    dgv.RowCount = grAndStAndDp.Count() + 1;
                    foreach(var gr in grAndStAndDp)
                    {
                        dgv.Rows[i].Cells[0].Value = gr.grname;
                        dgv.Rows[i].Cells[1].Value = gr.gryear;
                        dgv.Rows[i].Cells[2].Value = gr.grleader;
                        dgv.Rows[i].Cells[3].Value = gr.grdp;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Група";
                    dgv.Columns[1].HeaderCell.Value = "Курс";
                    dgv.Columns[2].HeaderCell.Value = "Староста";
                    dgv.Columns[3].HeaderCell.Value = "Кафедра";
                    break;

                case "Викладач":
                    var tcAndDp = (from tc in db.GetTable<Teacher>()
                                   join dp in db.GetTable<Department>()
                                   on tc.tc_dpID equals dp.dp_ID into a
                                   from b in a.DefaultIfEmpty()

                                   select new
                                   {
                                       tcname = tc.tc_name,
                                       dpname = b.dp_name ?? ""

                                   });

                    dgv.ColumnCount = 2;
                    i = 0;
                    dgv.RowCount = tcAndDp.Count() + 1;
                    foreach (var tc in tcAndDp)
                    {
                        dgv.Rows[i].Cells[0].Value = tc.tcname;
                        dgv.Rows[i].Cells[1].Value = tc.dpname;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Ім'я";
                    dgv.Columns[1].HeaderCell.Value = "Кафедра";
                    break;

                case "Куратор":
                    var crAndGrAndTc = (from cr in db.GetTable<Curator>()
                                        join gr in db.GetTable<Group>() on cr.cr_grID equals gr.gr_ID
                                        join tc in db.GetTable<Teacher>() on cr.cr_tcID equals tc.tc_ID
                                        orderby gr.gr_name
                                        select new
                                        {
                                            grname = gr.gr_name,
                                            tcname = tc.tc_name

                                        });

                    dgv.ColumnCount = 2;
                    i = 0;
                    dgv.RowCount = crAndGrAndTc.Count() + 1;
                    foreach (var cr in crAndGrAndTc)
                    {
                        dgv.Rows[i].Cells[0].Value = cr.grname;
                        dgv.Rows[i].Cells[1].Value = cr.tcname;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Група";
                    dgv.Columns[1].HeaderCell.Value = "Куратор";
                    break;

                case "Предмет":
                    var sbj = (from sb in db.GetTable<Subject>()
                               select new { sbname = sb.sb_name, sbinfo = sb.sb_info });
                                   

                    dgv.ColumnCount = 2;
                    i = 0;
                    dgv.RowCount = sbj.Count() + 1;
                    foreach (var sb in sbj)
                    {
                        dgv.Rows[i].Cells[0].Value = sb.sbname;
                        dgv.Rows[i].Cells[1].Value = sb.sbinfo;
                        i++;
                    }
                    dgv.Columns[0].HeaderCell.Value = "Назва";
                    dgv.Columns[1].HeaderCell.Value = "Інформація";
                    break;
                default:
                    MessageBox.Show("Помилка");
                    return;             
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cbTables.Text)
            {

                case "Студент":
                    AddStudent addStudent = new AddStudent();
                    addStudent.Show();
                    break;

                case "Кафедра":
                    AddDepartment addDepartment = new AddDepartment();
                    addDepartment.Show();
                    break;

                case "Група":
                    AddGroup addGroup = new AddGroup();
                    addGroup.Show();
                    break;

                case "Викладач":
                    AddTeacher addTeacher = new AddTeacher();
                    addTeacher.Show();
                    break;

                case "Предмет":
                    AddSubject addSubject = new AddSubject();
                    addSubject.Show();
                    break;

                default:
                    MessageBox.Show("Помилка");
                    return;
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            AddLesson addLesson = new AddLesson();
            addLesson.Show();
        }
    }
}
