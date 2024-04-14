using Microsoft.AspNetCore.Mvc;
using MyPortfolio.CQRSPattern.Handlers.ExperienceHandlers;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        private readonly GetExperienceQueryHandler _handler;

        public _ExperienceComponentPartial(GetExperienceQueryHandler handler)
        {
            _handler = handler;
        }

        public  IViewComponentResult Invoke() 
        {
            var values = _handler.Handle();
            return View(values);
        
        }
    }
}
