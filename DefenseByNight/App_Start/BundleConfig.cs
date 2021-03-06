﻿using DefenseByNight.Areas.AuthentificationManager;
using DefenseByNight.Areas.Rules;
using System.Web.Optimization;

namespace DefenseByNight.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap.bundle.min.js",
                      "~/Scripts/index.d.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/unbostrusive-ajax").Include(
                      "~/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-grid.min.css",
                      "~/Content/bootstrap-reboot.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                        "~/Content/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                        "~/Scripts/moment.min.js",
                        "~/Scripts/moment-with-locales.min.js"));

            LoginBundleConfig.RegisterBundles(bundles);
            RulesBundleConfig.RegisterBundles(bundles);
        }
    }
}