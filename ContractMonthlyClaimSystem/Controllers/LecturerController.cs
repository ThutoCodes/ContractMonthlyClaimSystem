using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;  
using System;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        // This action method displays the lecturer dashboard
        public IActionResult Dashboard()
        {
            // Fetch claims for the lecturer from your data source
            List<Claim> claims = GetClaimsForLecturer();
            return View(claims);
        }

        // This action method displays the form for submitting a new claim
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // Action to submit a new claim
        [HttpPost]
        public IActionResult SubmitClaim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                // Perform claim submission logic here
                claim.SubmissionDate = DateTime.Now;
                claim.Status = "Pending";
                claim.TotalAmount = claim.HoursWorked * claim.HourlyRate;

                // Save the new claim to your data store
                SaveClaim(claim);

                return RedirectToAction("Dashboard");
            }

            // If model state is not valid, redisplay the form with validation messages
            return View(claim);
        }

        // Action to upload supporting documents
        [HttpPost]
        public IActionResult UploadDocument(SupportingDocument document)
        {
            if (document != null && ModelState.IsValid)
            {
                // Handle document upload logic here
                SaveDocument(document);

                return RedirectToAction("Dashboard");
            }

            // If model state is not valid, redisplay the form with validation messages
            return RedirectToAction("Dashboard");
        }

        // Placeholder method for fetching claims for a lecturer
        private List<Claim> GetClaimsForLecturer()
        {
            // Replace with actual logic to fetch claims
            return new List<Claim>
        {
            new Claim { ClaimId = 1, HoursWorked = 10, TotalAmount = 500, Status = "Pending" },
            new Claim { ClaimId = 2, HoursWorked = 8, TotalAmount = 400, Status = "Approved" }
        };
        }

        // Placeholder method for saving a claim
        private void SaveClaim(Claim claim)
        {
            // Replace with actual logic to save the claim
        }

        // Placeholder method for saving a supporting document
        private void SaveDocument(SupportingDocument document)
        {
            // Replace with actual logic to save the document
        }
    }
}
