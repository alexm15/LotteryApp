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
        public ActionResult EnterContest(string firstName, string lastName, string email, int phone, DateTime dateOfBirth, string serialNumber)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var submission = new Submission();
                    submission.FirstName = firstName;
                    submission.SurName = lastName;
                    submission.Email = email;
                    submission.PhoneNumber = phone;
                    submission.DateOfBirth = dateOfBirth;
                    submission.SerialNumber = serialNumber;
                    // TODO: Add insert logic here
                    participants.Submissions.Add(submission);
                    return RedirectToAction(nameof(ViewParticipants));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult EnterContest(Submission submission)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // TODO: Add insert logic here
        //            participants.Submissions.Add(submission);
        //            return RedirectToAction(nameof(ViewParticipants));
        //        }
        //        return View();
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Lottery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
    }
}