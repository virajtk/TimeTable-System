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
    class LecturerService : ILecturerService
    {
        public bool addLecturer(Lecturer lecturer)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO lecturers (lec_name, employee_id, faculty, department, center, building, level, rank) VALUES (@lecname, @employeeid, @faculty, @department, @center, @building, @level, @rank)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@lecname", lecturer.Name);
                cmd.Parameters.AddWithValue("@employeeid", lecturer.EmployeeID);
                cmd.Parameters.AddWithValue("@faculty", lecturer.Faculty);
                cmd.Parameters.AddWithValue("@department", lecturer.Department);
                cmd.Parameters.AddWithValue("@center", lecturer.Center);
                cmd.Parameters.AddWithValue("@building", lecturer.Building);
                cmd.Parameters.AddWithValue("@level", lecturer.Level);
                cmd.Parameters.AddWithValue("@rank", lecturer.Rank);

                cmd.Prepare();

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

        public ArrayList getAllLecturers()
        {
            throw new NotImplementedException();
        }
    }
}
