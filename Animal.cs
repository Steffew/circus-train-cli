internal class Animal
{
    public Enums.Type Type { get; private set; }
    public Enums.Size Size { get; private set; }

    public Animal(Enums.Type type, Enums.Size size)
    {
        Type = type;
        Size = size;
    }
}
