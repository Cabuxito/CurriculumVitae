using CurriculumVitae.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurriculumVitae.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Projects> Projects = new();

        public void OnGet()
        {
            Projects.AddRange(
                new List<Projects>()
                {
                    new Projects
                    {
                        Name = "CoffeShop",
                        Description =
                            "I did make a CoffeShop in Razor Pages as my first project. The function was that I can see Coffes and Cakes, and have the chance to Order it" +
                            "and some basics functions.",
                        Url = "https://github.com/Cabuxito/CoffeeShop"
                    },
                    new Projects
                    {
                        Name = "Akvarie beregning Opgave",
                        Description = "Et program som er lavet i console og beregner akvaries rumfang i kubikmeter ved givende input.",
                        Url="https://github.com/Cabuxito/Akvarie-Opgave"
                    },
                    new Projects
                    {
                        Name = "Snake Game",
                        Description = "Jeg har lavet et snake spil som er lavet på WPF.",
                        Url= "https://github.com/Cabuxito/SnakeProjekt"
                    }
                }
            );
        }
    }
}
