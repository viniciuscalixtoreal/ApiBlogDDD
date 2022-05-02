using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiBlogDDD.Controllers
{
    public class ApiController : ControllerBase
    {
        protected Claim GetClaims(object claimType)
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)HttpContext.User.Identity;
            Claim claim = claimsIdentity.FindFirst((string)claimType);

            return claim;

        }
    }
}
