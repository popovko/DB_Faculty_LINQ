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
    public partial class AddTeacher : Form
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);

        public AddTeacher()
        {
            InitializeComponent();
            var dp = from d in db.GetTable<Department>()
                     select d.dp_name;
            foreach(var dep in dp)
            {
                cbTchDepartment.Items.Add(dep);
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var dpid = from d in db.GetTable<Department>()
                           where d.dp_name == cbTchDepartment.Text
                           select d.dp_ID;

                Helper.NameChecker(tbTchName.Text);
                Teacher teacher = new Teacher { tc_ID = dpid.ToList()[0], tc_name = tbTchName.Text };
                db.GetTable<Teacher>().InsertOnSubmit(teacher);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
