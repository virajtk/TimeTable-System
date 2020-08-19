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
    class SubjectService : ISubjectService
    {
        public bool addSubject(Subject subject)
        {
            Boolean result =false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO subjects (subjectName, subjectCode, offeredYear, offeredSem, LecHours, TuteHours, LabHours, EvaluationHours) VALUES (@subname, @subcode, @offeredyear, @offeredSem, @lechours, @tutehours, @labhours, @evaluationhours)";
                
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@subname", subject.SubjectName);
                cmd.Parameters.AddWithValue("@subcode", subject.SubjectCode);
                cmd.Parameters.AddWithValue("@offeredyear", subject.OfferedYear);
                cmd.Parameters.AddWithValue("@offeredSem", subject.OfferedSem);
                cmd.Parameters.AddWithValue("@lechours", subject.LabHours);
                cmd.Parameters.AddWithValue("@tutehours", subject.TuteHours);
                cmd.Parameters.AddWithValue("@labhours", subject.LabHours);
                cmd.Parameters.AddWithValue("@evaluationhours", subject.EvaluationHours);

                cmd.Prepare();

                //Console.WriteLine(cmd);

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

                //SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                //DataTable dataTable = new DataTable();
                //dataAdapter.Fill(dataTable);

                //if (dataTable.Rows.Count > 0)
                //{
                // MessageBox.Show("You are Logged in", "Login Successfull");
                //}
                //else
                //{
                //    MessageBox.Show("Login Failed", "Error");
                //}
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

        public ArrayList getAllSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
