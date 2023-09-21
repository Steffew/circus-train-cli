internal class Wagon
{
    public int Id { get; private set; }
    public int Size { get; private set; }
    public int MaxSize { get; private set; }
    public List<Animal> Animals { get; private set; }

    public Wagon(int id)
    {
        Id = id;
        Size = 0;
        MaxSize = 10;
        Animals = new List<Animal>();
    }

    public bool CheckForSpace(Animal animal)
    {
        return ((int)animal.Size >= MaxSize - Size);
    }

    public bool CheckForType(Enums.Type type)
    {
        foreach (Animal animal in Animals)
        {
            if (animal.Type == type)
            {
                return true;
            }
        }

        return false;
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}