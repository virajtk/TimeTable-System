using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Student
    {
        private String academicYear;
        private String programme;
        private String groupNumber;
        private String groupId;
        private String subGroupNumber;
        private String subGroupId;

        public string AcademicYear { get => academicYear; set => academicYear = value; }
        public string Programme { get => programme; set => programme = value; }
        public string GroupNumber { get => groupNumber; set => groupNumber = value; }
        public string GroupId { get => groupId; set => groupId = value; }
        public string SubGroupNumber { get => subGroupNumber; set => subGroupNumber = value; }
        public string SubGroupId { get => subGroupId; set => subGroupId = value; }

    }
}
