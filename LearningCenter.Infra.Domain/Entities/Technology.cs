namespace LearningCenter.Infra.Domain.Entities
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Technology() { }

        public Technology(string name)
        {
            Name= name;
        }
    }
}
