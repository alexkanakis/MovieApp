using MovieApp.Data;
using MovieApp.Models;

using MovieCatalogContext context = new MovieCatalogContext();

Movie movie = new Movie()
{
    Name = "Dune",
    DateTime = new DateTime(2021, 10, 22),
    Duration = new TimeSpan(2, 35, 0)
};
