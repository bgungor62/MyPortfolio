using Microsoft.AspNetCore.Mvc;
using MyPortfolio.CQRSPattern.Handlers.AboutHandlers;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly GetAboutQueryHandler _handler;

        public _AboutComponentPartial(GetAboutQueryHandler handler)
        {
            _handler = handler;
        }

        public IViewComponentResult Invoke()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
