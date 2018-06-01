using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PageRouteProblem.ViewComponents
{
    public class OnesViewComponentModel
    {
        public List<string> Messages { get; set; }
    }

    public class OnesViewComponent : ViewComponent
    {
        public OnesViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new OnesViewComponentModel()
            {
                Messages = new List<string>()
                {
                    "In Flames",
                    "Trigger",
                    "Fear is the Weakness",
                }
            });
        }
    }
}