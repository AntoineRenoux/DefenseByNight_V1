using System;
using System.Collections.Generic;
using System.Globalization;
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

        public bool Connected
        {
            get {
                return (FindFirst(ClaimTypes.Name) != null);
            }
        }

        public string Name
        {
            get {
                if (this.FindFirst(ClaimTypes.Name) != null)
                    return this.FindFirst(ClaimTypes.Name).Value;
                return string.Empty;
            }
        }

        public string Email
        {
            get {
                if (this.FindFirst(ClaimTypes.Email) != null)
                    return this.FindFirst(ClaimTypes.Email).Value;
                return string.Empty;
            }
        }

        public string MobilePhone
        {
            get {
                if (this.FindFirst(ClaimTypes.MobilePhone) != null)
                    return this.FindFirst(ClaimTypes.MobilePhone).Value;
                return string.Empty;
            }
        }

        public int Lang
        {
            get {
                return CultureInfo.CurrentCulture.LCID;
            }
        }
    }
}