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
    class TagService : ITagService
    {
        public bool addTag(Tag tag)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO tags (subjectName, subjectCode, relatedTag) VALUES (@subjectname, @subjectcode, @relatedtag)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@subjectname", tag.SubjectName);
                cmd.Parameters.AddWithValue("@subjectcode", tag.SubjectCode);
                cmd.Parameters.AddWithValue("@relatedtag", tag.RelatedTag);

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

        public ArrayList getAllTags()
        {
            throw new NotImplementedException();
        }
    }
}
