﻿using System;
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

        public bool deleteSubject(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM subjects WHERE id = @id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Subject> getAllSubjects()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Subject> arraySubs = null;


            try
            {
                string query = "SELECT * FROM subjects";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arraySubs = new List<Subject>();

                while (rdr.Read())
                {
                    Subject sub = new Subject();
                    sub.Id = rdr.GetInt32(0);
                    sub.SubjectName = rdr.GetString(1);
                    sub.SubjectCode = rdr.GetString(2);
                    sub.OfferedYear = rdr.GetInt32(3);
                    sub.OfferedSem = rdr.GetInt32(4);
                    sub.LecHours = rdr.GetInt32(5);
                    sub.TuteHours = rdr.GetInt32(6);
                    sub.LabHours = rdr.GetInt32(7);
                    sub.EvaluationHours = rdr.GetInt32(8);

                    arraySubs.Add(sub);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return arraySubs;
        }

        public Subject getSubject(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Subject sub = new Subject();

            try
            {
                string query = "SELECT * FROM subjects WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    sub.Id = rdr.GetInt32(0);
                    sub.SubjectName = rdr.GetString(1);
                    sub.SubjectCode = rdr.GetString(2);
                    sub.OfferedYear = rdr.GetInt32(3);
                    sub.OfferedSem = rdr.GetInt32(4);
                    sub.LecHours = rdr.GetInt32(5);
                    sub.TuteHours = rdr.GetInt32(6);
                    sub.LabHours = rdr.GetInt32(7);
                    sub.EvaluationHours = rdr.GetInt32(8);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return sub;
        }

        public bool updateSubject(int id, Subject subject)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE subjects SET subjectName = @subname, subjectCode = @subcode, offeredYear = @offeredyear, offeredSem = @offeredSem, LecHours = @lechours, TuteHours = @tutehours, LabHours = @labhours, EvaluationHours = @evaluationhours WHERE id = @id";

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
                cmd.Parameters.AddWithValue("@id", id);

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
    }
}
