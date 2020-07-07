using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IList<Movie> NewMovies { get; set; } = new List<Movie>();

        public IndexModel(ILogger<IndexModel> logger, RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// An unhandled exception occurred while processing the request.
        ///     InvalidOperationException: Multiple handlers matched.The following handlers matched route data and had all constraints satisfied:
        ///     Void OnGet(), System.Threading.Tasks.Task OnGetAsync()
        /// </summary>
        /// 
        //public void OnGet()
        //{
        //    NewMovies =  _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(3).ToList();
        //}

        //public IActionResult OnGet()
        //{
        //    NewMovies =  _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(3).ToList();
        //    return Page();
        //}

        public async Task OnGetAsync()
        {
            NewMovies = await _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(3).ToListAsync();
            _logger.LogInformation($"OnGetAsync @ {DateTime.Now}");
        }
    }
}
