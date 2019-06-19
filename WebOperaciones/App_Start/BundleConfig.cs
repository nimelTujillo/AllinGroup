using System.Web;
using System.Web.Optimization;

namespace WebOperaciones
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Scripts/main").Include(
                      "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/Vendor/js").Include(
                      "~/vendor/jquery/jquery-3.2.1.min.js",
                      "~/vendor/animsition/js/animsition.min.js",
                      "~/vendor/bootstrap/js/popper.js",
                      "~/vendor/bootstrap/js/bootstrap.min.js",
                      "~/vendor/select2/select2.min.js",
                      "~/vendor/daterangepicker/moment.min.js",
                      "~/vendor/daterangepicker/daterangepicker.js",
                      "~/vendor/countdowntime/countdowntime.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      //"~/Content/site.css",
                      "~/Content/util.css",
                      "~/Content/main.css"));

            bundles.Add(new StyleBundle("~/Content/scss").Include(
                      "~/Content/scss/navbar.css",
                      "~/Content/scss/nav.css",
                      "~/Content/scss/forms.css",
                      "~/Content/scss/transitions.css",
                      "~/Content/scss/mixins/grid.css",
                      "~/Content/scss/mixins/background-variant.css",
                      "~/Content/scss/utilities/position.css",
                      "~/Content/scss/utilities/spacing.css"));

            bundles.Add(new StyleBundle("~/Vendor/css").Include(
                      "~/vendor/bootstrap/css/bootstrap.min.css",
                      "~/vendor/animate/animate.css",
                      "~/vendor/css-hamburgers/hamburgers.min.css",
                      "~/vendor/animsition/css/animsition.min.css",
                      "~/vendor/select2/select2.min.css",
                      "~/vendor/daterangepicker/daterangepicker.css"));
        }
    }
}
