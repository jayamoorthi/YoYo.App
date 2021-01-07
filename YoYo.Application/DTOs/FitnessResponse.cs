using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo.Application.DTOs
{
    public class FitnessResponse
    {
        public int FitnessTestID { get; set; }
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string StartDtTime { get; set; }
        public string EndDtTime { get; set; }
        public bool IsWarned { get; set; }
        public bool IsWarning { get; set; }
        public bool IsStoped { get; set; }
        public bool IsStarted { get; set; }
        public int ShuttleID { get; set; }
        public string AccumulatedShuttleDistance { get; set; }
        public string SpeedLevel { get; set; }
        public int ShuttleNo { get; set; }
        public string Speed { get; set; }
        public string LevelTime { get; set; }
        public string CommulativeTime { get; set; }
        public string StartTime { get; set; }
        public string CompletionTime { get; set; }
        public string ApproxVo2Max { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }
    }
}
