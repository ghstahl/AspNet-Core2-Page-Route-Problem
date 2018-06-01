using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageRouteProblem.Pages
{
    public class TwosModel : PageModel
    {
        public string Message { get; set; }

        public async Task OnGetAsync(string id)
        {
            Message = id;
        }
    }
}
