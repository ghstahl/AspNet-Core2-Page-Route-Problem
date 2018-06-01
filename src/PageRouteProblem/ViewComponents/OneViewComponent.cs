using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PageRouteProblem.ViewComponents
{
    public class OneViewComponentModel
    {
        public string Id { get; set; }

    }
    public class OneViewComponent : ViewComponent
    {
        public OneViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            return View(new OneViewComponentModel(){Id = id});
        }
    }
}
