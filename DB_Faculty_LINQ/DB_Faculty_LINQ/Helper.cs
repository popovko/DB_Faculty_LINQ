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
    class Helper
    {
        static string connectionStr = MainForm.connectionStr;
        static DataContext db = new DataContext(connectionStr);

        public static void NameChecker(string name)
        {
            if (name.Length < 2)
                throw new Exception("Некоректне ім'я");
            
            name = name.ToLower();
            for (int i=0; i<name.Length; i++)
            {
                if (name[i] < 'а' || name[i] > 'я' || name[i] == 'і')
                    throw new Exception("Некоректне ім'я");
            }       
        }

        public static string DelSpase(string s)
        {
            string res = "";
            for(int i=0; i< s.Length - 1; i++)
            {
                if (!(s[i] == ' ' && s[i + 1] == ' '))
                    res += s[i];
            }
            res += s[s.Length-1];
            return res;
        }

        public static int IDgrFromNameGr(string name)
        {
            var id = from i in db.GetTable<Group>()
                     where i.gr_name == name
                     select i.gr_ID;
            if (id.ToList().Count == 0)
                throw new Exception("Група не знайдена");
            else
                return id.ToList()[0]; 
        }

        public static int IDsbFromNameSb(string name)
        {
            var id = from i in db.GetTable<Subject>()
                     where i.sb_name == name
                     select i.sb_ID;
            if (id.ToList().Count == 0)
                throw new Exception("Предмет не знайдений");
            else
                return id.ToList()[0];
        }

        public static int NumLsFromIDLs(int id)
        {
            var lsnum = from ln in db.GetTable<Lesson>()
                        where ln.ls_ID == id
                        select ln.ls_num;

            if (lsnum.ToList().Count == 0)
                throw new Exception("Пара не знайдена");
            else
                return lsnum.ToList()[0];
        }

        public static string DOWLsFromIDLs(int id)
        {
            var lsdow = from ln in db.GetTable<Lesson>()
                        where ln.ls_ID == id
                        select ln.ls_DOW;

            if (lsdow.ToList().Count == 0)
                throw new Exception("Пара не знайдена");
            else
                return lsdow.ToList()[0];
        }

        public static string NameGrFromIdGr(int id)
        {
            var name = from n in db.GetTable<Group>()
                     where n.gr_ID == id
                     select n.gr_name;
            if (name.ToList().Count == 0)
                throw new Exception("Група не знайдена");
            else
                return name.ToList()[0];
        }

        public static int IdTcFromNameTc(string name)
        {
            MessageBox.Show(name);
            var id = from i in db.GetTable<Teacher>()
                     where i.tc_name == name
                     select i.tc_ID;
            if (id.ToList().Count == 0)
                throw new Exception("Викладач не знайдений");
            else
                return id.ToList()[0];
        }

        public static string NameTcFromIdTc(int id)
        {
            var name = from n in db.GetTable<Teacher>()
                       where n.tc_ID == id
                       select n.tc_name;
            if (name.ToList().Count == 0)
                throw new Exception("Викладач не знайдений");
            else
                return name.ToList()[0];
        }
    }
    
}
