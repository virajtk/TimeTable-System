using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ILocationService
    {
        Boolean addLocation(Location location);
        ArrayList getAllTags();
    }
}
