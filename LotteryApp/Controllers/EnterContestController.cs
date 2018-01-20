using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotteryApp.Controllers
{
    public class EnterContestController : Controller
    {
        // GET: EnterContest
        public ActionResult Index()
        {
            return View();
        }

        // POST: EnterContest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSubmission(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}