using CurriculumVitae.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace CurriculumVitae.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Portfolio> Portfolios = new();

        public void OnGet()
        {
            Portfolios.AddRange
            (
                new List<Portfolio>()
                {
                    new Portfolio
                    {
                        Title = "Programming Languages",
                        Skills = new List<Skill>
                        {
                           new Skill
                           {
                               Name = "C-Sharp",
                               Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg"
                           },
                           new Skill
                           {
                                Name = "JavaScript",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/javascript/javascript-original.svg"
                           },
                           new Skill
                           {
                                Name = "Arduino C",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/arduino/arduino-original.svg"
                           }
                        }
                    },
                    new Portfolio 
                    {
                        Title = "Database",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "Microsoft SQL",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain.svg"
                            },
                            new Skill
                            {
                                Name = "MongoDB",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mongodb/mongodb-original.svg"
                            },
                            new Skill
                            {
                                Name = "mySQL",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original-wordmark.svg"
                            }
                        }
                    },
                    new Portfolio
                    {
                        Title = "Web Development",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "HTML5",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original-wordmark.svg"
                            },
                            new Skill
                            {
                                Name = "CSS",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original-wordmark.svg"
                            },
                            new Skill
                            {
                                Name = "NodeJS",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/nodejs/nodejs-original.svg"
                            },
                            new Skill
                            {
                                Name = "Bootstrap",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/bootstrap/bootstrap-original.svg"
                            },
                        }
                    },
                    new Portfolio
                    {
                        Title = "Version Control",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "Github",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg"
                            },
                            new Skill
                            {
                                Name = "Gitlab",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/gitlab/gitlab-original.svg"
                            }
                        }
                    },
                    new Portfolio
                    {
                        Title = "GUI Development",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "WPF",
                                Icon = "https://spin.atomicobject.com/wp-content/uploads/Microsoft_WPF.png"
                            }
                        }
                    },
                }
            );
        }
    }
}