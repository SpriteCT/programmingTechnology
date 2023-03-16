namespace ProgrammingTechnology
{
    public abstract class Building
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }

        public abstract void GetInfo();
    }
}
