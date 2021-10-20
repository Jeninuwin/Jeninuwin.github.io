using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class GraphicModel : PageModel
    {
        private readonly ILogger<GraphicModel> _logger;

        public GraphicModel(ILogger<GraphicModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
