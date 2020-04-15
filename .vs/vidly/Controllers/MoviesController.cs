using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

       /* public ViewResult Movie()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }*/


        // GET: Movies
        public ActionResult Customer()
        {
            var movie = new Movie() { Name = "Shrek!!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith " },
                new Customer { Name = "Marry Williams " }
            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
            
        }
        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]


       /* public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }*/


            

        public ActionResult GetCustomer(int Id)
        {
            List<Customer> Customers = new List<Customer>()
            {
                 new Customer {Id =1, Name = "John Smith " },
                new Customer {Id = 2, Name = "Marry Williams " }
            };
            var myCustomer = Customers.Where(x => x.Id == Id).FirstOrDefault();

            return Content(myCustomer.Name);


        }
        public ActionResult Edit(int id)
        {
            return Content("Id= " + id);

        }



        public ActionResult GetMovie(int Id)
        {
            List<Movie> Movies = new List<Movie>()
            {
                 new Movie {Id =1, Name = "Shrek " },
                new Movie {Id = 2, Name = "Wall-e" }
            };
            var myMovie = Movies.Where(x => x.Id == Id).FirstOrDefault();

            return Content(myMovie.Name);


        }


        public ActionResult Edit2(int id)
        {
            return Content("Id= " + id);

        }


    }
}