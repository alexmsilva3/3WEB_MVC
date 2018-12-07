using System.Web;
using System.Web.Optimization;

namespace _3WEB
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery2").Include(
                        "~/Content/js/jquery.min.js",
                        "~/Content/js/popper.js",
                        "~/Content/js/jquery.flexslider-min.js",
                        "~/Content/js/jquery.easing.js",
                        "~/Content/js/jquery.fitvids.js",
                        "~/Content/js/jquery.carouFredSel.min.js",
                        //"~/Content/js/jquery.validate.js",
                        "~/Content/js/theme-plugins.js",
                        "~/Content/js/jquery.isotope.min.js",
                        "~/Content/js/imagesloaded.js",
                        "~/Content/js/view.min.js?auto",
                        "~/Content/plugins/aos/aos.js",

                        "~/Content/plugins/rs-plugin/js/jquery.themepunch.tools.min.js",
                        "~/Content/plugins/rs-plugin/js/jquery.themepunch.revolution.min.js",

                        "~/Content/js/theme-core.js",
                        "~/Content/js/theme.js",
                        "~/Content/js/theme.init.js",
                        "~/Scripts/toastr.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      //"~/Scripts/bootstrap.js",
                      //"~/Scripts/respond.js",
                       "~/Content/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/BasicCSS").Include(
                        //"~/Content/bootstrap.css",
                        //"~/Content/site.css",
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/style.css",
                        "~/Content/css/font-awesome.min.css",
                        "~/Content/css/streamline-icon.css",
                        "~/Content/css/header.css",
                        "~/Content/css/portfolio.css",
                        "~/Content/css/blog.css",
                        "~/Content/css/v-animation.css",
                        "~/Content/css/v-bg-stylish.css",
                        "~/Content/css/font-icons.css",
                        "~/Content/css/shortcodes.css",
                        "~/Content/css/utilities.css",
                        "~/Content/css/theme-responsive.css",
                        "~/Content/plugins/aos/aos.css",
                        "~/Content/plugins/owl-carousel/owl.theme.css",
                        "~/Content/plugins/owl-carousel/owl.carousel.css",
                        "~/Content/toastr.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/CurrentCSS").Include(
                        "~/Content/plugins/rs-plugin/css/settings.css"));

            bundles.Add(new StyleBundle("~/Content/skin").Include(
                        "~/Content/css/skin/default.css"));

            bundles.Add(new StyleBundle("~/Content/CustomCSS").Include(
                        "~/Content/css/custom.css"));
        }
    }
}
