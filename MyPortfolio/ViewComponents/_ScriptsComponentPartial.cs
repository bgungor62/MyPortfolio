using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
