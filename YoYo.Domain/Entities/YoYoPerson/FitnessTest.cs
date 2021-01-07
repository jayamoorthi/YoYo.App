using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo.Domain.Entities.YoYoPerson
{
    public class FitnessTest
    {
        public int FitnessTestID { get; set; }
        public int PersonID { get; set; }     
        public string StartDtTime { get; set; }
        public string EndDtTime { get; set; }
        public bool IsWarned { get; set; }
        public bool IsWarning { get; set; }
        public bool IsStoped { get; set; }
        public bool IsStarted { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedAt  { get; set; }
        public DateTime ModifiedBy { get; set; }

    }
}
