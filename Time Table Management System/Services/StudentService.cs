using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data.SQLite;
using System.Data;

namespace Time_Table_Management_System.Services
{
    class StudentService : IStudentService
    {
        public bool addStudent(Student student)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO students (academicYear, programme, groupNumber, subGroupNumber, groupId, subGroupId) VALUES (@academicyear, @programme, @groupno, @subgroupno, @groupid, @subgroupid)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@academicyear", student.AcademicYear);
                cmd.Parameters.AddWithValue("@programme", student.Programme);
                cmd.Parameters.AddWithValue("@groupno", student.GroupNumber);
                cmd.Parameters.AddWithValue("@subgroupno", student.SubGroupNumber);
                cmd.Parameters.AddWithValue("@groupid", student.GroupId);
                cmd.Parameters.AddWithValue("@subgroupid", student.SubGroupId);
                

                cmd.Prepare();

                //Console.WriteLine(cmd);

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

     
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public ArrayList getAllStudents()
        {
            throw new NotImplementedException();
        }

    }
}
