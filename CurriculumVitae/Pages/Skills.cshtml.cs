using CurriculumVitae.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurriculumVitae.Pages
{
    public class SkillsModel : PageModel
    {

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
                    new Portfolio
                    {
                        Title = "Framework",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "Razor Pages",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg"
                            },
                            new Skill
                            {
                                Name = "Blazor",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg"
                            },
                            new Skill
                            {
                                Name = "Entity Framework",
                                Icon = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg"
                            }
                        }
                    },
                    new Portfolio
                    {
                        Title = "Big Data",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "ETL ( Extract, Transform, Load )",
                                Icon = "https://thenounproject.com/api/private/icons/6105266/edit/?backgroundShape=SQUARE&backgroundShapeColor=%23000000&backgroundShapeOpacity=0&exportSize=752&flipX=false&flipY=false&foregroundColor=%23000000&foregroundOpacity=1&imageFormat=png&rotation=0"
                            },
                            new Skill
                            {
                                Name = "ELT ( Extract, Load, Transform )",
                                Icon = "https://thenounproject.com/api/private/icons/6105266/edit/?backgroundShape=SQUARE&backgroundShapeColor=%23000000&backgroundShapeOpacity=0&exportSize=752&flipX=false&flipY=false&foregroundColor=%23000000&foregroundOpacity=1&imageFormat=png&rotation=0"
                            },
                        }
                    },
                    new Portfolio
                    {
                        Title = "API",
                        Skills = new List<Skill>
                        {
                            new Skill
                            {
                                Name = "Rest API",
                                Icon = "https://thenounproject.com/api/private/icons/5998475/edit/?backgroundShape=SQUARE&backgroundShapeColor=%23000000&backgroundShapeOpacity=0&exportSize=752&flipX=false&flipY=false&foregroundColor=%23000000&foregroundOpacity=1&imageFormat=png&rotation=0"
                            },
                            
                        }
                    },
                }
            );
        }
    }
}
