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

            cbTchDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.NameChecker(tbTchName.Text);
                Teacher teacher = new Teacher { tc_name = tbTchName.Text, tc_dpID = Helper.IdDpfromNameDp(cbTchDepartment.Text) };
                db.GetTable<Teacher>().InsertOnSubmit(teacher);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Готово");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
