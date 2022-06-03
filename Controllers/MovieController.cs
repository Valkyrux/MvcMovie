using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Diagnostics;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        private List<Movie> movieList = new List<Movie>();

        public void prendiDati()
        {
            Movie movie1 = new Movie()
            {
                Id = 1,
                Title = "When Harry met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Photo = "~/img/harrysally.jpg",
                AlternateText = "Pranaya Rout Photo not available"
            };
            movieList.Add(movie1);

            Movie movie2 = new Movie()
            {
                Id = 2,
                Title = "Il Codice Da Vinci",
                ReleaseDate = DateTime.Parse("2006-5-19"),
                Genre = "Thriller",
                Price = 11.00M,
                Photo = "~/img/Il_codice_da_Vinci.jpg",
                AlternateText = "Copertina del film"
            };
            movieList.Add(movie2);

            Movie movie3 = new Movie()
            {
                Id = 3,
                Title = "Joker",
                ReleaseDate = DateTime.Parse("2019-4-10"),
                Genre = "Drammatico/Giallo",
                Price = 9.50M,
                Photo = "~/img/jok.jpg",
                AlternateText = "Copertina Joker"
            };
            movieList.Add(movie3);

            Movie movie4 = new Movie()
            {
                Id = 4,
                Title = "Titanic",
                ReleaseDate = DateTime.Parse("1998-1-16"),
                Genre = "Romantico/Drammatico",
                Price = 4.99M,
                Photo = "~/img/tit.webp",
                AlternateText = "Immagine Titanic"
            };
            movieList.Add(movie4);
        }

        public IActionResult ShowMovie()
        {
            prendiDati();
            return View(movieList);
        }

        public IActionResult ProvaParametri(string Nome, string Cognome)
        {
            return View("ProvaParametri", new Tuple<string, string>(Nome, Cognome));
        }

        [Route("/Hai_Vinto")]
        public IActionResult MiglioneDiEuro()
        {
            return View("Euro");
        }
    }
}
