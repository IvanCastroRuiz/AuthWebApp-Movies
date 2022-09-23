using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie.models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        //public DbSet<RazorPageMovie.models.Movie> Movie { get; set; } = default!;
        public DbSet<Movie> Movie { get; set; } = default!;
    }
