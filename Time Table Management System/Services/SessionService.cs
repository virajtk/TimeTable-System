using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class SessionService : ISessionService
    {
        public bool addSession(SessionDTO session)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO sessions (lecturer1_name, lecturer2_name, subject_code, subject_name, tag, group_code, student_count, duration) VALUES (@lec1_name, @lec2_name, @sub_code, @sub_name, @tag, @group_code, @student_count, @duration)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@lec1_name", session.Lec1_name);
                cmd.Parameters.AddWithValue("@lec2_name", session.Lec2_name);
                cmd.Parameters.AddWithValue("@sub_code", session.Subject_code);
                cmd.Parameters.AddWithValue("@sub_name", session.Subject_name);
                cmd.Parameters.AddWithValue("@tag", session.Tag);
                cmd.Parameters.AddWithValue("@group_code", session.Group_code);
                cmd.Parameters.AddWithValue("@student_count", session.Student_count);
                cmd.Parameters.AddWithValue("@duration", session.Duration);

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

        public bool deleteSession(SessionDTO session)
        {
            throw new NotImplementedException();
        }

        public List<SessionDTO> getAllSessions()
        {
            throw new NotImplementedException();
        }

        public SessionDTO GetSession(int id)
        {
            throw new NotImplementedException();
        }

        public bool updateSession(int id, SessionDTO session)
        {
            throw new NotImplementedException();
        }
    }
}
