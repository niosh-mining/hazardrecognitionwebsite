using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazardRecognition.Models
{
    public class UserInputModel
    {
        public string ClickedPointsJSON
        {
            get
            {
                return JsonConvert.SerializeObject(ClickedPoints);
            }
            set
            {
                ClickedPoints = JsonConvert.DeserializeObject<List<PointModel>>(value);
            }
        }
        public List<PointModel> ClickedPoints { get; set; }

        /// <summary>
        /// Date the session started
        /// </summary>
        public string Start
        {
            get
            {
                return StartDateTime.ToString();
            }
            set
            {
                StartDateTime = DateTime.Parse(value);
            }
        }

        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Date the session end
        /// </summary>
        public string End
        {
            get
            {
                return EndDateTime.ToString();
            }
            set
            {
                EndDateTime = DateTime.Parse(value);
            }
        }

        public DateTime EndDateTime { get; set; }
    }
}