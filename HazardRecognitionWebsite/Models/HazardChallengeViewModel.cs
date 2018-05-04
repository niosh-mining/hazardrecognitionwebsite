using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazardRecognition.Models
{
    public class HazardChallengeViewModel
    {
        public List<Hazard> Hazards { get; set; }

        public int ChallengeId { get; set; }
        public int TotalChallenges { get; set; }
        public string ImageName { get; set; }
        public string ThumbnailName { get; set; }
        public bool ShowResults { get; set; }
        public List<PointModel> CorrectClicks { get; set; }
        public List<PointModel> IncorrectClicks { get; set; }
        public int TotalClicks { get; set; }
        public Boolean IsLast { get; set; }
        public Boolean IsFirst { get; set; }

        public HazardChallengeViewModel(int id, string imagePath, string thumbnailPath, int totalChallenges)
        {
            ChallengeId = id;
            ImageName = imagePath;
            ThumbnailName = thumbnailPath;
            TotalChallenges = 4;
            Hazards = new List<Hazard>();

            CorrectClicks = new List<PointModel>();

            IsLast = id == totalChallenges;
            IsFirst = id == 1;
        }

        /// <summary>
        /// Perform a hit test on all hazards against points that the user clicked
        /// </summary>
        /// <param name="clickedPoints"></param>
        public void Score(IEnumerable<PointModel> clickedPoints)
        {
            if (clickedPoints == null)
            {
                // this could happen when the user clicks through the challenges before it finishes loading
                // we will just assume no clicks occurred
                clickedPoints = new List<PointModel>();
            }

            IncorrectClicks = clickedPoints.ToList();
            if (Hazards == null)
            {
                return;
            }

            TotalClicks = clickedPoints.Count();
            
            foreach (var hazard in Hazards)
            {
                var correctPoints = hazard.HitTest(clickedPoints);
                if (correctPoints.Count() > 0)
                {
                    foreach (var p in correctPoints)
                    {
                        CorrectClicks.Add(p);
                        IncorrectClicks.Remove(p);
                    }
                }
            }



        }
    }
}