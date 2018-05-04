using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazardRecognition.Models
{
    public class Hazard
    {
        /// <summary>
        /// Clockwise list of points that make up the polygon
        /// </summary>
        public List<PointModel> HotspotPoints { get; set; }
        public PointModel HazardCenter
        {
            get
            {
                if (HotspotPoints == null || HotspotPoints.Count < 3)
                    return new PointModel();

                var x = (HotspotPoints.Max(m => m.X) + HotspotPoints.Min(m => m.X)) / 2;
                var y = (HotspotPoints.Max(m => m.Y) + HotspotPoints.Min(m => m.Y)) / 2;
                return new PointModel(x, y);
            }
        }
        public string Text { get; set; }
        public string Title { get; set; }
        public bool Selected { get; set; }
        public string ImageURL { get; set; }

        /// <summary>
        /// Set Selected to true if any of the points are inside the hazard. Returns the set of points that are correct.
        /// </summary>
        /// <param name="points"></param>
        public IEnumerable<PointModel> HitTest(IEnumerable<PointModel> points)
        {
            List<PointModel> matchedPoints = new List<PointModel>();

            Selected = false;
            if (points == null)
                return null;

            for (int i = 0; i < points.Count(); i++)
            {
                if (HitTest(points.ElementAt(i)))
                {
                    Selected = true;
                    matchedPoints.Add(points.ElementAt(i));
                }
            }

            return matchedPoints;
        }

        /// <summary>
        /// Tests a single point to determine if that point is within the HotSpot polygon
        /// </summary>
        /// <param name="point"></param>
        private bool HitTest(PointModel point)
        {
            if (point == null || HotspotPoints == null)
                return false;

            return isPointInPolygon(
                HotspotPoints.Count,
                HotspotPoints.Select(s => s.X).ToArray(),
                HotspotPoints.Select(s => s.Y).ToArray(),
                point.X,
                point.Y
                );
        }

        /// <summary>
        /// Some sort of sorcery from http://stackoverflow.com/questions/217578/how-can-i-determine-whether-a-2d-point-is-within-a-polygon
        /// </summary>
        /// <param name="nvert">Number of points in polygon</param>
        /// <param name="vertx">Array of x points</param>
        /// <param name="verty">Array of y points</param>
        /// <param name="testx">Point x to test</param>
        /// <param name="testy">Point y to test</param>
        /// <returns></returns>
        private bool isPointInPolygon(int nvert, double[] vertx, double[] verty, double testx, double testy)
        {
            int i, j = 0;
            bool c = false;
            for (i = 0, j = nvert - 1; i < nvert; j = i++)
            {
                if (((verty[i] > testy) != (verty[j] > testy)) &&
                 (testx < (vertx[j] - vertx[i]) * (testy - verty[i]) / (verty[j] - verty[i]) + vertx[i]))
                    c = !c;
            }
            return c;
        }
    }
}