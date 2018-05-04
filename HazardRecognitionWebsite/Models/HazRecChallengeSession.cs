using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardRecognition.Models
{
    // Todo actually this shouldn't be called "session"

    /// <summary>
    /// Represents a session undertaken by a user on the website for the Hazard Recognition challenge page.
    /// This includes information about a single challenge (image)
    /// </summary>
    public class HazRecChallengeSession
    {
        /// <summary>
        /// Primary key - the unique session of user interaction with the hazrec challange
        /// </summary>
        public Guid SessionId { get; set; }

        /// <summary>
        /// The group id of the challenge sessions (simple way to group all the challenges the user took)
        /// </summary>
        public Guid SessionGroupId { get; set; }

        /// <summary>
        /// Date the session started
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Date the session ended
        /// </summary>
        public DateTime? EndDate { get; set; }

        public int ChallengeId { get; set; }

        public string ClickedPointsJSON { get; set; }
    }
}
