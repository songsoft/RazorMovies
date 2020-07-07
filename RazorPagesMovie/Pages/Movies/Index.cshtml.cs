using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    /// <summary>
    /// Razor Pages are derived from PageModel. By convention, the PageModel-derived class is called <PageName>Model. 
    /// The constructor uses dependency injection to add the RazorPagesMovieContext to the page. 
    /// </summary>

    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Movie> Movie { get; set; }

        // Searching
        // For security reasons, you must opt in to binding GET request data to page model properties. 
        // Verify user input before mapping it to properties. 
        // Opting into GET binding is useful when addressing scenarios that rely on query string or route values.
        // (SupportsGet = true) is required for binding on GET requests.
        // The ASP.NET Core runtime uses model binding to set the value of the SearchString property from the query string (?searchString=Ghost) 
        //            or route data (https://localhost:5001/Movies/Ghost). 
        // Model binding is not case sensitive.
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        /******************************************************************************************/

        /// <summary>
        /// https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/page?view=aspnetcore-3.1&tabs=visual-studio
        /// 
        /// Handler methods in Razor Pages are also based on naming conventions. 
        /// The basic methods work by matching HTTP verbs used for the request to the name of the method, and they are prefixed with "On": 
        ///     OnGet(), OnPost(), OnPut() etc. 
        /// They also have asynchronous equivalents:  OnPostAsync(), OnGetAsync() etc. 
        /// 
        /// 
        /// When a request is made for the page, the OnGetAsync method returns a list of movies to the Razor Page. 
        ///     OnGetAsync or OnGet is called to initialize the state of the page. 
        /// In this case, OnGetAsync gets a list of movies and displays them.
        /// 
        /// 
        /// When OnGet returns void or OnGetAsync returnsTask, no return statement is used. 
        /// When the return type is IActionResult or Task<IActionResult>, a return statement must be provided. 
        /// 
        /// </summary>
        /// <returns></returns>
        
        public async Task OnGetAsync()
        {
            // Full list
            // Movie = await _context.Movie.ToListAsync();

            // With filter/search

            // The SelectList of genres is created by projecting the distinct genres.
            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            var movies = from m in _context.Movie select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            
            Movie = await movies.ToListAsync();

            _logger.LogInformation($"OnGetAsync @ {DateTime.Now} - {Movie.Count()} movies");
        }

        /******************************************************************************************/
    }
}
