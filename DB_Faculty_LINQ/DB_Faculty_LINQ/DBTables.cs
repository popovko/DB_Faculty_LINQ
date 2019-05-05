using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_Faculty_LINQ
{
    [Table(Name = "Student")]
    public class Student
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "st_ID")]
        public int st_ID { get; set; }
        [Column(Name = "st_name")]
        public string st_name { get; set; }
        [Column(Name = "st_grID")]
        public int st_grID { get; set; }
    }

    [Table(Name = "Group")]
    public class Group
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "gr_ID")]
        public int gr_ID { get; set; }
        [Column(Name = "gr_name")]
        public string gr_name { get; set; }
        [Column(Name = "gr_dpID", CanBeNull = true)]
        public int gr_dpID{ get; set; }
        [Column(Name = "gr_year")]
        public int gr_year { get; set; }
        [Column(Name = "gr_leader", CanBeNull = true)]
        public int gr_leader { get; set; }
    }

    [Table(Name = "Teacher")]
    public class Teacher
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "tc_ID")]
        public int tc_ID { get; set; }
        [Column(Name = "tc_name")]
        public string tc_name { get; set; }
        [Column(Name = "tc_dpID", CanBeNull = true)]
        public int tc_dpID { get; set; }
    }

    [Table(Name = "Department")]
    public class Department
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "dp_ID")]
        public int dp_ID { get; set; }
        [Column(Name = "dp_name")]
        public string dp_name { get; set; }
        [Column(Name = "dp_chief", CanBeNull = true)]
        public int dp_chief { get; set; }
    }

    [Table(Name = "Curator")]
    public class Curator
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "cr_ID")]
        public int cr_ID { get; set; }
        [Column(Name = "cr_grID")]
        public int cr_grID { get; set; }
        [Column(Name = "cr_tcID")]
        public int cr_tcID { get; set; }
    }

    [Table(Name = "Lesson")]
    public class Lesson
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ls_ID")]
        public int ls_ID { get; set; }
        [Column(Name = "ls_sbID")]
        public int ls_sbID { get; set; }
        [Column(Name = "ls_DOW")]
        public string ls_DOW { get; set; }
        [Column(Name = "ls_num")]
        public int ls_num { get; set; }
    }

    [Table(Name = "Subject")]
    public class Subject
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "sb_ID")]
        public int sb_ID { get; set; }
        [Column(Name = "sb_name")]
        public string sb_name { get; set; }
        [Column(Name = "sb_info", CanBeNull = true)]
        public string sb_info { get; set; }
    }

    [Table(Name = "LessonGroup")]
    public class LessonGroup
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "lsgr_ID")]
        public int lsgr_ID { get; set; }
        [Column(Name = "lsgr_grID")]
        public int lsgr_grID { get; set; }
        [Column(Name = "lsgr_lsID")]
        public int lsgr_lsID { get; set; }
    }

    [Table(Name = "LessonTeacher")]
    public class LessonTeacher
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "lstc_ID")]
        public int lstc_ID { get; set; }
        [Column(Name = "lstc_tcID")]
        public int lstc_tcID { get; set; }
        [Column(Name = "lstc_lsID")]
        public int lstc_lsID { get; set; }
        [Column(Name = "lstc_aud")]
        public int lstc_aud { get; set; }
    }

}

