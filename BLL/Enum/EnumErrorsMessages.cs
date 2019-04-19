using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Enum
{
    public static class EnumErrorsMessages
    {
        #region Missing fields
        public readonly static string ERR_FIRSTNAME_MISSING = "ERR_FIRSTNAME_MISSING";
        public readonly static string ERR_LASTNAME_MISSING = "ERR_LASTNAME_MISSING";
        public readonly static string ERR_EMAIL_MISSING = "ERR_EMAIL_MISSING";
        public readonly static string ERR_PASSWORD_MISSING = "ERR_PASSWORD_MISSING";
        public readonly static string ERR_BIRTHDATE_MISSING = "ERR_BIRTHDATE_MISSING";
        public readonly static string ERR_ALIAS_MISSING = "ERR_ALIAS_MISSING";
        #endregion

        #region Wrong input
        public readonly static string ERR_PASSWORD_TO_SHORT = "ERR_PASSWORD_TO_SHORT";
        #endregion

    }
}
