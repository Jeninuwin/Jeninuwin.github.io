using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItMe.Pages
{
    public class CSProjectModel : PageModel
    {
        private readonly ILogger<CSProjectModel> _logger;

        public CSProjectModel(ILogger<CSProjectModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
