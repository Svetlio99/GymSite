using System.Web;
using System.Web.Optimization;

namespace vgym
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.lightbox-0.5.min.js",
                        "~/Scripts/jquery-migrate.min.js",
                        "~/Scripts/jquery.easing-1.3.js",
                        "~/Scripts/namespace.js",
                        "~/Scripts/slider.js",
                        "~/Scripts/eg-compressed.js",
                        "~/Scripts/jquery.heroCarousel-1.3.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/eg-compressed.css",
                      "~/Content/site.css"));
        }
    }
}
