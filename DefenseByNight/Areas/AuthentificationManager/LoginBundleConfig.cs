using System.Web.Optimization;

namespace DefenseByNight.Areas.AuthentificationManager
{
    public static class LoginBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/custom-validator-auth").Include(
                   "~/Areas/AuthentificationManager/Scripts/validation-connexion.js",
                   "~/Areas/AuthentificationManager/Scripts/validation-registration.js"));
        }
    }
}