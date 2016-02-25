using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wiskunde2A.Models;

namespace Wiskunde2A.Controllers
{
    public class QuestionsController : Controller
    {
        private Wiskunde2AContext db = new Wiskunde2AContext();

        // GET: Questions
        public ActionResult Index()
        {
            Random rnd = new Random();
            /*for (int i = 0; i < 50; i++)
            {
                int rndOne = rnd.Next(1, 50);
                int rndTwo = rnd.Next(1, 50);
                int result = rndOne + rndTwo;
                Question q = new Question();
                q._Question = rndOne + " + " + rndTwo + "?";
                q.Answer = result.ToString();
                q.Elaboration = "-";
                db.Questions.Add(q);
            }
            db.SaveChanges();*/
            List<Question> questions = db.Questions.ToList();
            int randomQuestionID = rnd.Next(0, questions.Count());
            Question q = questions[randomQuestionID];
            
            return View(q);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
