using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PageRouteProblem.ViewComponents
{
    public class TwoViewComponentModel
    {
        public string Id { get; set; }

    }
    public class TwoViewComponent : ViewComponent
    {
        public TwoViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            return View(new TwoViewComponentModel() { Id = id });
        }
    }
}