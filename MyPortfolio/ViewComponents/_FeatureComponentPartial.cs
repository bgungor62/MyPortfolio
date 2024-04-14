using Microsoft.AspNetCore.Mvc;
using MyPortfolio.CQRSPattern.Handlers.FeatureHandlers;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {

        private readonly GetFeatureQueryHandlers _handlers;

        public _FeatureComponentPartial(GetFeatureQueryHandlers handlers)
        {
            _handlers = handlers;
        }

        public IViewComponentResult Invoke()
        {
            var values = _handlers.Handle();
            return View(values);
        }
    }
}
