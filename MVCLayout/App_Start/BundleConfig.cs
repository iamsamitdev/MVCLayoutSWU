using System.Web;
using System.Web.Optimization;

namespace MVCLayout
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/custom").Include("~/Scripts/scripts.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/styles.css"));
        }
    }
}
