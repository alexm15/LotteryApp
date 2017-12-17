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
        private SerialNumberRegistry serialNumberRegistry;
        private Participants participants = new Participants();
        
        public LotteryController()
        {
            serialNumberRegistry = new SerialNumberRegistry();

        }
        // GET: Lottery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewParticipants()
        {
            
            return View();
        }

        // GET: Lottery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lottery/EnterConstest
        public ActionResult EnterContest()
        {
            var submission = new Submission();
            submission.AvailableSerialNumbers = new SerialNumberRegistry();
            return View(submission);
        }

        // POST: Lottery/EnterContest
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnterContest(Submission submission)
        {
            try
            {
                // TODO: Add insert logic here
                participants.Submissions.Add(submission);
                return RedirectToAction(nameof());
            }
            catch
            {
                return View();
            }
        }

        // GET: Lottery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lottery/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(EnterContest));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lottery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lottery/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(EnterContest));
            }
            catch
            {
                return View();
            }
        }
    }
}