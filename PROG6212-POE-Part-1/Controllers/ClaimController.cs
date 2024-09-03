using Microsoft.AspNetCore.Mvc;
using PROG6212_POE_Part_1.Models;

namespace PROG6212_POE_Part_1.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(ClaimModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the claim (e.g., save to database)
                // Redirect or return a success view
                return RedirectToAction("VerifyClaims");
            }

            // If model validation fails, return the same view with the current model to show validation errors
            return View(model);
        }
        public IActionResult TrackStatus()
        {
            return View();
        }
        public IActionResult VerifyClaims()
        {
            return View();
        }
    }
}
