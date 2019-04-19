using System.Web.Optimization;

namespace DefenseByNight.Areas.Login
{
    public class LoginBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/custom-validator").Include(
                       "~/Areas/Login/Scripts/script-custom-validation-connexion.js"));
        }
    }
}