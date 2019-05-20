using System.Web.Optimization;

namespace DefenseByNight.Areas.Rules
{
    public static class RulesBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Rules").Include(
                    "~/Areas/Rules/Content/disciplines.css"
                    ));

            bundles.Add(new ScriptBundle("~/bundle/Rules/Discipline").Include(
                   "~/Areas/Rules/Scripts/disciplineModule.js"
                   ));
        }
    }
}