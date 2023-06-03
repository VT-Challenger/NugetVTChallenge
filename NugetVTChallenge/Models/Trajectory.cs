using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetVTChallenge.Models {
    public class Trajectory {
        public int Tid { get; set; }
        public string TournamentName { get; set; }
        public string TournamentImage { get; set; }
        public string TournamentRank { get; set; }
        public DateTime TournamentDateInit { get; set; }
        public string OrganizatorImage { get; set; }
        public bool Winner { get; set; }
    }
}
