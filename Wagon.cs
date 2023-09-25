internal class Wagon
{
    public int Id { get; private set; }
    public int Size { get; private set; }
    public List<Animal> Animals { get; private set; }
    public const int MaxSize = 10;

    public Wagon(int id)
    {
        Id = id;
        Size = 0;
        Animals = new List<Animal>();
    }

    public bool CheckForSpace(Animal animal)
    {
        return (Size + (int)animal.Size) <= MaxSize;
    }

    public bool CheckForType(Enums.Type type)
    {
        return Animals.Any(animal => animal.Type == type);
    }

    public bool CheckForSize(Enums.Size size)
    {
        return Animals.Any(animal => animal.Size == size);
    }

    public void AddAnimal(Animal animal)
    {
        Size += (int)animal.Size;
        Animals.Add(animal);
    }

    public bool CanAddAnimal(Animal newAnimal)
    {
        if (!CheckForSpace(newAnimal))
            return false;

        if (newAnimal.Type == Enums.Type.Carnivore)
        {
            return !Animals.Any(animal => animal.Size <= newAnimal.Size);
        }
        else
        {
            return !Animals.Any(animal => animal.Type == Enums.Type.Carnivore && animal.Size >= newAnimal.Size);
        }
    }
}