internal class Wagon
{
    public int Id { get; private set; }
    public int Size { get; private set; }
    public List<Animal> Animals { get; private set; }
    public int MaxSize { get; private set; }

    public Wagon(int id)
    {
        Id = id;
        Size = 0;
        MaxSize = 10;
        Animals = new List<Animal>();
    }

    public bool CheckForSpace(Animal animal)
    {
        return (Size + (int)animal.Size) <= MaxSize;
    }

    private bool CanAddAnimal(Animal newAnimal)
    {
        if (!CheckForSpace(newAnimal))
            return false;

        if (newAnimal.Type == Enums.Type.Carnivore)
        {
            if (Animals.Any(animal => animal.Size <= newAnimal.Size))
                return false;
        }
        else
        {
            if (Animals.Any(animal => animal.Type == Enums.Type.Carnivore))
                return false;
        }

        return true;
    }

    public bool TryAddAnimal(Animal newAnimal)
    {
        if (CanAddAnimal(newAnimal))
        {
            Size += (int)newAnimal.Size;
            Animals.Add(newAnimal);
            return true;
        }
        return false;
    }
}