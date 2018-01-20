using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LotteryApp.Models;
using LotteryClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotteryApp.Controllers
{
    public class LotteryController : Controller
    {
        private Participants participants;
        private Submission newSubmission;
        
        public LotteryController()
        {

            participants = new Participants();
            newSubmission = new Submission();
            newSubmission.SerialNumberRegistry = new SerialNumberRegistry();

        }
        // GET: Lottery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewParticipants()
        {
            
            return View(participants);
        }

        // GET: Lottery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lottery/EnterConstest
        public ActionResult EnterContest()
        {

            return View(newSubmission);
        }

        //POST: Lottery/EnterContest
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSubmission([FromForm]Submission submission)
        {


            participants.Submissions.Add(submission);
            try
            {
                if (ModelState.IsValid)
                {
                    //submission.
                    

                    
                }
            }
            catch
            {
                return View();
            }
            return View("ViewParticipants", participants);
        }


        // GET: Lottery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
    }
}