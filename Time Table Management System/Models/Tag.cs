using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Tag
    {
        private String subjectName;
        private String subjectCode;
        private String relatedTag;

        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string SubjectCode { get => subjectCode; set => subjectCode = value; }
        public string RelatedTag { get => relatedTag; set => relatedTag = value; }
    }
}
