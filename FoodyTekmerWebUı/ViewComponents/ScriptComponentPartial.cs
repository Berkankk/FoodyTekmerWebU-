using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUı.ViewComponents
{
    public class ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
