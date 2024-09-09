using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers { 
namespace ContractMonthlyClaimSystem.Models { 



    public class AdminController : Controller
    {
        public IActionResult ReviewClaims()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult ReviewClaim(int ClaimId, string decision, string comments)
        {

                //Fetch claim by claimId and update the status
                //decision == "Approved" or "Rejected"
                return RedirectToAction("ReviewClass");

            }
        }
    }
}