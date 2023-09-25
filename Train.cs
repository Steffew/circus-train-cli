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
        animals = animals.OrderBy(animal => animal.Size).ThenBy(animal => animal.Type).ToList();
    }

    public void AssignAnimals(List<Animal> animals)
    {
        foreach (var animal in animals)
        {
            bool isAssigned = false;

            var suitableWagon = Wagons
                .OrderBy(w => 10 - w.Size)
                .FirstOrDefault(w => w.CanAddAnimal(animal));

            if (suitableWagon != null)
            {
                suitableWagon.AddAnimal(animal);
                isAssigned = true;
            }

            if (!isAssigned)
            {
                var newWagon = AddWagon();
                newWagon.AddAnimal(animal);
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