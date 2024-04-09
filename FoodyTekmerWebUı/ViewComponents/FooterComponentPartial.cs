using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUı.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }

}

