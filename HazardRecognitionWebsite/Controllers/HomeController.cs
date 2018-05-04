using Newtonsoft.Json;
using HazardRecognition.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HazardRecognition.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Required)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Challenge(int id)
        {
            return View("ChallengeKR", HazardChallenges.GetChallenge(id));
        }

        [HttpPost]
        public ActionResult Challenge(UserInputModel model, int id)
        {
            saveInput(id, model);

            // no more challenges - score all, go to results page
            if (id == HazardChallenges.GetNumberOfChallenges())
            {
                ResultSummaryViewModel resultModel = new ResultSummaryViewModel();
                Guid groupId = Guid.NewGuid();

                for (int i = 1; i <= HazardChallenges.GetNumberOfChallenges(); i++)
                {
                    var scoredChallenge = HazardChallenges.GetChallenge(i);
                    var pointModel = getPreviousInput(i);
                    if (pointModel == null)
                        return View("Index");
                    scoredChallenge.Score(pointModel.ClickedPoints);
                    scoredChallenge.ShowResults = true;

                    resultModel.ScoredChallenges.Add(scoredChallenge);
                    Session?.Add("results", resultModel);
                }

                return View("ResultsSummary", resultModel);
            }
                        
            return RedirectToAction("Challenge", new { id = id + 1 });
        }

        public ActionResult ChallengeResult(int id)
        {
            ResultSummaryViewModel results = (ResultSummaryViewModel) Session?["results"];
            if (results == null)
                return RedirectToAction("Index");
            return View("ChallengeResultsKR", results.ScoredChallenges[id - 1]);
        }

        public ActionResult ResultSummary()
        {
            ResultSummaryViewModel resultModel = (ResultSummaryViewModel) Session?["results"];
            if (resultModel == null)
                return RedirectToAction("Index");
            return View("ResultsSummary", resultModel);
        }

        public ActionResult Help()
        {
            return View("Help");
        }

        public ActionResult Restart()
        {
            Session.Clear();
            return RedirectToAction("Challenge", new { id = 1 });
        }

        private UserInputModel getPreviousInput(int id)
        {
            if (Session != null && Session["userInput" + id] != null)
                return (UserInputModel)Session["userInput" + id];
            else
                return null;
        }

        private void saveInput(int id, UserInputModel input)
        {
            if (Session == null)
                return;

            Session["userInput" + id] = input;
        }
    }
}