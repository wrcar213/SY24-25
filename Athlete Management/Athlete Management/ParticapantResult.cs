using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Management
{
    internal class ParticapantResult
    {
        public string BibNumber { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public TimeSpan FinishTime { get; set; }
        public int Rank { get; set; }
        // Add other relevant properties like checkpoint times
    }
    List<ParticipantResult> results = new List<ParticipantResult>();
}
