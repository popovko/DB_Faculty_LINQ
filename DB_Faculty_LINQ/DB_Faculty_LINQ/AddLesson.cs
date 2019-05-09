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

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
