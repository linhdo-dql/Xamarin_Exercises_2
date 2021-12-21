using SQLite;
using SQLiteStudents.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteStudents.Database
{
    public class StudentSQLite
    {
        readonly SQLiteAsyncConnection _connection;
        public StudentSQLite(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Student>().Wait();
        }
        public Task<List<Student>> GetAllStudent()
        {
            return _connection.Table<Student>().ToListAsync();
        }

        public Task<Student> GetStudentById( int id)
        {
            return _connection.Table<Student>().Where(s => s.Id == id).FirstOrDefaultAsync();
        } 

        public Task<int> InsertOrUpdateStudent(Student student)
        {
            if(student.Id!=0)
            {
               return _connection.UpdateAsync(student);
            }
            else
            {
               return _connection.InsertAsync(student);
            }
        }
        
        public Task<int> DeleteStudent(Student student)
        {
            return _connection.DeleteAsync(student);
        }
    }
}
