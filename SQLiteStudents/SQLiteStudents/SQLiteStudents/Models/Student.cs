using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteStudents.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Class { get; set; }
    }
}
