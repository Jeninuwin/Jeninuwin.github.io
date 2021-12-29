using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItMe.Pages
{
    public class GraphicDesignModel : PageModel
    {
        private readonly ILogger<GraphicDesignModel> _logger;

        public GraphicDesignModel(ILogger<GraphicDesignModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
