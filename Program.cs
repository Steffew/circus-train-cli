Train train = new Train();

List<Animal> animals = new List<Animal>()
{
    new Animal(Enums.Type.Herbivore, Enums.Size.Small),
    new Animal(Enums.Type.Herbivore, Enums.Size.Large),
    new Animal(Enums.Type.Carnivore, Enums.Size.Small),
    new Animal(Enums.Type.Herbivore, Enums.Size.Medium),
    new Animal(Enums.Type.Herbivore, Enums.Size.Large),

};

train.SortAnimals(animals);
train.AssignAnimals(animals);
train.PrintAnimals(animals);