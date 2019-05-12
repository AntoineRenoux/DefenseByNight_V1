using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace DefenseByNight.Models
{
    public class AppUserModel : ClaimsPrincipal
    {
        public AppUserModel(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public string Name
        {
            get {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Email
        {
            get {
                return this.FindFirst(ClaimTypes.Email).Value;
            }
        }

        public string MobilePhone
        {
            get {
                return this.FindFirst(ClaimTypes.MobilePhone).Value;
            }
        }
    }
}