using System.Web;
using System.Web.Optimization;

namespace MVC
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",

                      "~/Content/MyDesign/RoomsStyle.css",

                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/RoomDesign").Include(
                
                "~/Content/MyDesign/RoomsStyle.css"
                
                ));

            bundles.Add(new StyleBundle("~/NavDesign").Include(

                "~/Content/MyDesign/NavDesign.css"));


            bundles.Add(new StyleBundle("~/TeacherDesign").Include(

                "~/Content/MyDesign/TeacherDesign.css"));




            bundles.Add(new StyleBundle("~/Student").Include(
                "~/Content/MyDesign/Student.css"));

            bundles.Add(new StyleBundle("~/detail").Include(
          "~/Content/MyDesign/GetDetailsStudent.css"));

            bundles.Add(new StyleBundle("~/RoomDeta").Include(

            "~/Content/MyDesign/RoomDetail.css"

            ));


            bundles.Add(new StyleBundle("~/buttonUpdate").Include(

                "~/Content/MyDesign/TeacherUpdateButton.css"));


        }
    }
}
