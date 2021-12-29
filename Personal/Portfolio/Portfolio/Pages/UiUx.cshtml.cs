using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class UiUxModel : PageModel
    {
        private readonly ILogger<UiUxModel> _logger;

        public UiUxModel(ILogger<UiUxModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
