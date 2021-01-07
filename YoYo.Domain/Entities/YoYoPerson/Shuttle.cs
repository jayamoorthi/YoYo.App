using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo.Domain.Entities.YoYoPerson
{
    public class Shuttle
    {
        public int ShuttleID { get; set; }
        public int FitnessTestID { get; set; }
        public string AccumulatedShuttleDistance { get; set; }
        public string SpeedLevel { get; set; }
        public int ShuttleNo { get; set; }
        public string Speed { get; set; }
        public string LevelTime { get; set; }
        public string CommulativeTime { get; set; }
        public string StartTime { get; set; }
        public string CompletionTime { get; set; }
        public string ApproxVo2Max { get; set; }
        public bool IsWarned { get; set; }
        public bool IsWarning { get; set; }
        public bool IsStoped { get; set; }
        public bool IsBeep { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }

    }
}
