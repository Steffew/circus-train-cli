internal class Train
{
    public List<Wagon> Wagons { get; private set; }
    private int wagonAmount = 0;

    public Train()
    {
        Wagons = new List<Wagon>();
    }

    public Wagon AddWagon()
    {
        wagonAmount++;
        Wagon wagon = new Wagon(wagonAmount);
        Wagons.Add(wagon);
        return wagon;
    }

    public void SortAnimals(List<Animal> animals)
    {
        foreach (var animal in animals)
        {

        }
    }
}