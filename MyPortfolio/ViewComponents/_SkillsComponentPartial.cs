using Microsoft.AspNetCore.Mvc;
using MyPortfolio.CQRSPattern.Handlers.SkillsHandlers;

namespace MyPortfolio.ViewComponents
{
    public class _SkillsComponentPartial : ViewComponent
    {
        private readonly GetSkillsQueryHandler _handler;

        public _SkillsComponentPartial(GetSkillsQueryHandler handler)
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
