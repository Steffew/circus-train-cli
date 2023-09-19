internal class Wagon
{
    public int Id { get; private set; }
    public List<Animal> Animals { get; private set; }

    public Wagon(int id)
    {
        Id = id;
        Animals = new List<Animal>();
    }
}