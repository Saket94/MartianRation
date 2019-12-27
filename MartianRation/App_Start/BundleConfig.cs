using System.Web;
using System.Web.Optimization;

namespace MartianRation
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

            
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //           "~/Scripts/jquery.validate*", "~/Scripts/PacketRationJS/InsertRation.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/customJs").Include(
                 "~/Scripts/JS/jquery.validate.min.js",
                 "~/Scripts/JS/jquery.validate.unobtrusive.min.js",
                 "~/Scripts/DataTable/JS/jquery.1.10.13.dataTables.min.js",
                 "~/Scripts/JS/js/jquery-ui-1.12.1.min.js",
                 "~/Scripts/DataTable/JS/bootstrap.3.0.3.min.js",
                 "~/Scripts/BootStrap/bootstrap-datepicker.1.6.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/customBootStrap").Include(
                "~/Scripts/BootStrap/bootstrap.3.3.7.min.css",
                "~/Scripts/BootStrap/bootstrap-datepicker.1.6.4.css"));

            
        }
    }
}
