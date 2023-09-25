namespace CurriculumVitae.Data
{
    public class Portfolio
    {
        public string? Title { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Skill
    {
        public string? Name { get; set; }
        public string? Icon { get; set; }
    }
}
