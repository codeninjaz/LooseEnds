using System.Web;
using System.Web.Optimization;

namespace WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Bundles/scripts").Include(
                      "~/Content/Scripts/bootstrap.js",
                      "~/Content/Scripts/respond.js",
                      "~/Content/Scripts/Global.js"));

            bundles.Add(new ScriptBundle("~/Bundles/adminscripts").Include(
          "~/Content/Scripts/bootstrap.js",
          "~/Content/Scripts/respond.js",
          "~/Content/Scripts/excanvas.js",
          "~/Content/Scripts/morris-data.js",
          "~/Content/Scripts/morris.js",
          "~/Content/Scripts/raphael.js",
          "~/Content/Scripts/Global.js"));
            //"~/Content/Scripts/flot-data.js",
            //                      "~/Content/Scripts/jquery.flot.js",
            //"~/Content/Scripts/jquery.flot.resize.js",
            //          "~/Content/Scripts/jquery.flot.tooltip.js",

            bundles.Add(new StyleBundle("~/Bundles/css").Include(
                      "~/Content/Css/bootstrap.css",
                      "~/Content/Css/site.css",
                      "~/Content/Css/morris.css",
                      "~/Content/Css/font-awesome.css",
                      "~/Content/Css/sb.css"));

            bundles.Add(new StyleBundle("~/Bundles/admincss").Include(
                      "~/Content/Css/bootstrap.css",
                      "~/Content/Css/site.css",
                      "~/Content/Css/morris.css",
                      "~/Content/Css/sb-admin.css",
                      "~/Content/Css/font-awesome.css"));
        }
    }
}
