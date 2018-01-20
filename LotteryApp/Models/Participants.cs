using System.Collections.Generic;

namespace LotteryApp.Models
{
    public class Participants
    {
        public List<Submission> Submissions { get; set; } = new List<Submission>();
    }
}
