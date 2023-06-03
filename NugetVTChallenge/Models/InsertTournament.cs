using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetVTChallenge.Models {
    public class InsertTournament {

        public Tournament JsonTournament { get; set; }
        public List<Round> JsonRounds { get; set; }
        public List<Match> JsonMatches { get; set; }

    }
}
