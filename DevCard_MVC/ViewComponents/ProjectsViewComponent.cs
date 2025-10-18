using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Models.Project>
            {
                new Models.Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg", "Snapp"),
                new Models.Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "Zoodfood"),
                new Models.Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس","project-3.jpg", "Monop"),
                new Models.Project(4, "فضاپیما", "برنامه مدیریت فضاپیماهای ناسا","project-4.jpg", "Nasa"),
            };
            return View("_Projects", projects);
        }
    }
}
