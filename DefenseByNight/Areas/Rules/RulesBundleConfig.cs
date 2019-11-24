using System.Web.Optimization;

namespace DefenseByNight.Areas.Rules
{
    public static class RulesBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/DisciplineDescription").Include(
                      "~/Areas/Rules/Content/DisciplineDescription.css"));
        }
    }
}