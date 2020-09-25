﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ISessionService
    {
        Boolean addSession(SessionDTO session);
        List<SessionDTO> getAllSessions();
        SessionDTO GetSession(int id);
        Boolean deleteSession(SessionDTO session);
        Boolean updateSession(int id, SessionDTO session);
    }
}
