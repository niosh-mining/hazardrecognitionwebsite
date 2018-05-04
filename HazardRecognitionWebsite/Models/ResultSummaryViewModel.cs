using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazardRecognition.Models
{
    public class ResultSummaryViewModel
    {
        public List<HazardChallengeViewModel> ScoredChallenges { get; set; } = new List<HazardChallengeViewModel>();
    }
}