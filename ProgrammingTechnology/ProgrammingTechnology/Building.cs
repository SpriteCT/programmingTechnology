namespace ProgrammingTechnology
{
    abstract class Building
    {
        public virtual string Name { get; set; }
        public virtual string Adress { get; set; }
        public virtual string Description { get; set; }

        public abstract void GetInfo();
    }
}
