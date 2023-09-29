internal class Train
{
    public List<Wagon> Wagons { get; private set; }

    public Train()
    {
        Wagons = new List<Wagon>();
    }

    private Wagon GetNewWagon()
    {
        Wagon wagon = new Wagon(Wagons.Count);
        Wagons.Add(wagon);
        return wagon;
    }

    private void SortAnimals(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Type != b.Type ? a.Type.CompareTo(b.Type) : -a.Size.CompareTo(b.Size));
    }

    public void AssignAnimals(List<Animal> animals)
    {
        SortAnimals(animals);

        foreach (Animal animal in animals)
        {
            Wagon? suitableWagon = Wagons
                .OrderBy(w => w.MaxSize - w.Size)
                .FirstOrDefault(w => w.TryAddAnimal(animal));

            if (suitableWagon == null)
            {
                Wagon newWagon = GetNewWagon();
                newWagon.TryAddAnimal(animal);
            }
        }
    }

    public void PrintAnimals(List<Animal> animals)
    {
        foreach (Wagon wagon in Wagons)
        {
            Console.WriteLine($"Wagon ID: {wagon.Id} - Total size: {wagon.Size}");
            foreach (Animal animal in wagon.Animals)
            {
                Console.WriteLine($"  Animal: {animal.Type} - {animal.Size}");
            }
        }
    }
}