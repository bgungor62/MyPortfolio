﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _SkillsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}