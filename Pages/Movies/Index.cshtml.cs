﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviePage.Data;
using MoviePage.Models;

namespace MoviePage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviePage.Data.MoviePageContext _context;

        public IndexModel(MoviePage.Data.MoviePageContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
