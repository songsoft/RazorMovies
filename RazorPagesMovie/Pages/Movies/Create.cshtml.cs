using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The OnGet method initializes any state needed for the page. 
        /// The Create page doesn't have any state to initialize, so Page is returned. Later in the tutorial, an example of OnGet initializing state is shown. 
        /// The Page method creates a PageResult object that renders the Create.cshtml page.
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            return Page();
        }

        /// <summary>
        /// The Movie property uses the [BindProperty] attribute to opt-in to model binding. 
        /// When the Create form posts the form values, the ASP.NET Core runtime binds the posted values to the Movie model.
        /// </summary>

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    // Must have [BindProperty], or Movie is null
        //    _context.Movie.Add(Movie);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}

        public IActionResult OnPost()
        {
            // If there are any model errors, the form is redisplayed, along with any form data posted. 
            // Most model errors can be caught on the client-side before the form is posted. 
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Must have [BindProperty], or Movie is null
            _context.Movie.Add(Movie);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
