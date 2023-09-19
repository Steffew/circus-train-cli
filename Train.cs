internal class Train
{
    public List<Wagon> Wagons { get; private set; }

    public Train(int id)
    {
        Wagons = new List<Wagon>();
    }
}