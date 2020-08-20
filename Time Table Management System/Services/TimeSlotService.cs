using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class TimeSlotService : ITimeSlotService
    {
        public bool addTimeSlots(TimeSlot timeSlot)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO timeslots (stHours, stMinutes, etHours, etMinutes) VALUES (@stHours, @stMinutes, @etHours, @etMinutes)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@stHours", timeSlot.StHours);
                cmd.Parameters.AddWithValue("@stMinutes", timeSlot.StMinutes);
                cmd.Parameters.AddWithValue("@etHours", timeSlot.EtHours);
                cmd.Parameters.AddWithValue("@etMinutes", timeSlot.EtMinutes);

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
