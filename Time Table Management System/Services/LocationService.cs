using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class LocationService : ILocationService
    {
        public bool addLocation(Location location)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");

            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO locations (buildingName, roomName, roomType,capacity) VALUES (@buildingname, @roomname, @roomtype,@capacity)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@buildingname", location.BuildingName);
                cmd.Parameters.AddWithValue("@roomname", location.RoomName);
                cmd.Parameters.AddWithValue("@roomtype", location.RoomType);
                cmd.Parameters.AddWithValue("@capacity", location.Capacity);
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

