using BLL.Enum;
using DTO;
using System.Globalization;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    public class BaseController : Controller
    {
        public int CTX_LANGUAGE_ID
        {
            get {
                return ((CultureInfo)Session[EnumSession.Culture]).LCID;
            }
        }

        public UserDTO CTX_USER_DTO
        {
            get {
                return (UserDTO)Session[EnumSession.CurrentUserDto];
            }
        }
    }
}