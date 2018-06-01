using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PageRouteProblem.ViewComponents
{
    public class TwosViewComponentModel
    {
        public List<string> Messages { get; set; }
    }
    public class TwosViewComponent : ViewComponent
    {
        public TwosViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new TwosViewComponentModel()
            {
                Messages = new List<string>()
                {
                    "Ratt",
                    "Round and Round",
                    "Lay it down",
                }
            });
        }
    }
}
