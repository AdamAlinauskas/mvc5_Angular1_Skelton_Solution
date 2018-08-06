using System.Web;
using System.Web.Optimization;

namespace web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/angularjs").
                Include("~/Scripts/angular.min.js").
                Include("~/Scripts/angular-route.min.js").
                Include("~/Scripts/angular-animate.min.js").
                Include("~/Scripts/angular-messages.min.js").
                Include("~/Scripts/angular-filter.min.js"));



            bundles.Add(new ScriptBundle("~/bundles/employee")
                .IncludeDirectory("~/Scripts/Employee/","*.js",true)
            );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
