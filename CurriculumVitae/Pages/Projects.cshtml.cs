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
                        Name = "Aquarium volume calculator",
                        Description = "The program is a console version and calculates the volume of an aquarium and shows the result in cm and liter.",
                        Url="https://github.com/Cabuxito/Akvarie-Opgave"
                    },
                    new Projects
                    {
                        Name = "Snake Game",
                        Description = "I got a projekt where I did copy a Snake Game in WPF, add some features and do it more user responsive.",
                        Url= "https://github.com/Cabuxito/SnakeProjekt"
                    },
                    new Projects
                    {
                        Name = "Intelligent IoT-Controlled House",
                        Description = "I created a display output ( Screen ), where it shows a menu and some functions.",
                        Url = "https://github.com/Cabuxito/EmbeddedOpgave"

                    },
                      new Projects
                    {
                        Name = "eShop",
                        Description = "I got a project about an eShop, I need to make database with EntityFrameworkCore and XunitTest all the methods," +
                        " so we can implement razor pages next week and blazor after.",
                        Url= "https://github.com/Cabuxito/eShopOpgave"
                    },
                        new Projects
                    {
                        Name = "Blackjack Game",
                        Description = "I have a projekt where I need to improve my skills with javaScript. So I need to do a BlackJack game on HTML and JS, and have some basics functions.",
                        Url= "https://github.com/Cabuxito/HappyBody"
                    },
                }
            );
        }
    }
}
