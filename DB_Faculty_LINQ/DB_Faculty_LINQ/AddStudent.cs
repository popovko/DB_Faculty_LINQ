using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace DB_Faculty_LINQ
{
    public partial class AddStudent : Form
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);

        public AddStudent()
        {
            InitializeComponent();
            


            var gr = from g in db.GetTable<Group>()
                     select g.gr_name;
            foreach(var group in gr)
            {
                cbStGroup.Items.Add(group);
            }

            cbStGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var idgr = from g in db.GetTable<Group>()
                           where g.gr_name == cbStGroup.Text
                           select g.gr_ID;

                Helper.NameChecker(tbStName.Text);
                Student student = new Student { st_grID = idgr.ToList()[0], st_name = tbStName.Text };
                db.GetTable<Student>().InsertOnSubmit(student);
                db.SubmitChanges();

            }
            catch(Exception ex)
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
