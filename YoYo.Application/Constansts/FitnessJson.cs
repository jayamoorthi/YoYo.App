using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo.Application.Features.Fitness.Queries.GetAll;

namespace YoYo.Application.Constansts
{

    /// <summary>
    /// Static data for page load
    /// </summary>
    public static class FitnessTestData
    {        

        public static Task<List<FitnessResponse>> GetFitnessData()
        {
            return Task.FromResult( new List<FitnessResponse>
            {
                new FitnessResponse
                {
                    FitnessTestID = 1,
                    PersonID = 1,
                    Name  = "Charvik Jai ",
                    IsWarned = false,
                    IsStoped = false,
                    IsCompleted = false,
                    IsStarted = false,
                    AccumulatedShuttleDistance = "0",
                    SpeedLevel = "0",
                    Speed = "0",
                    ShuttleNo = 0,
                    LevelTime = "0",
                    CommulativeTime = "0",
                    StartTime = "0",
                    ApproxVo2Max = "0",
                    CompletionTime = "0"
                },
                new FitnessResponse
                {
                    FitnessTestID = 2,
                    PersonID =2,
                    Name  = "Jai ",
                    IsWarned = false,
                    IsStoped = false,
                    IsCompleted = false,
                    IsStarted = false,
                    AccumulatedShuttleDistance = "0",
                    SpeedLevel = "0",
                    Speed = "0",
                    ShuttleNo = 0,
                    LevelTime = "0",
                    CommulativeTime = "0",
                    StartTime = "0",
                    ApproxVo2Max = "0",
                    CompletionTime = "0"
                },
                new FitnessResponse
                {
                    FitnessTestID = 3,
                    PersonID = 3,
                    Name  = "Shankar Jai",
                    IsWarned = false,
                    IsStoped = false,
                    IsCompleted = true,
                    IsStarted = false,
                    AccumulatedShuttleDistance = "3640",
                    SpeedLevel = "23",
                    Speed = "19",
                    ShuttleNo =8,
                    LevelTime = "7.6",
                    CommulativeTime = "28:45",
                    StartTime = "28:28",
                    ApproxVo2Max = "66.98",
                    CompletionTime = "0"
                },
                new FitnessResponse
                {
                    FitnessTestID = 4,
                    PersonID = 4,
                    Name  = "Seenu Eng ",
                    IsWarned = false,
                    IsStoped = false,
                    IsCompleted = true,
                    IsStarted = false,
                    AccumulatedShuttleDistance = "3600",
                    SpeedLevel = "21",
                    Speed = "19",
                    ShuttleNo = 7,
                    LevelTime = "7.6",
                    CommulativeTime = "28:27",
                    StartTime = "28:10",
                    ApproxVo2Max = "66.64",
                    CompletionTime = "0"
                }

            });
        }


    }
}
