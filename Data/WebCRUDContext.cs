#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Paz.Eyal._5H.WebCRUD.Models;

    public class WebCRUDContext : DbContext
    {
        public WebCRUDContext (DbContextOptions<WebCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Paz.Eyal._5H.WebCRUD.Models.Movie> Movie { get; set; }
    }
