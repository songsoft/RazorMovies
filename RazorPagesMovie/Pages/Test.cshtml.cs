using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet()
        {
            ViewData["TIME"] = DateTime.Now.ToString();
        }
    }
}