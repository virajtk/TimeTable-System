﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ILecturerService
    {
        Boolean addLecturer(Lecturer lecturer);
        ArrayList getAllLecturers();
    }
}
