﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesMovie.Pages
{
    public class IndexModel_Orig : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel_Orig(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnGetAsync()
        {

        }
    }
}
