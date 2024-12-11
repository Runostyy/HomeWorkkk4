// Клас Тварина
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

// Універсальний клас GenericList<T> з обмеженням на тип T
public class GenericList<T> where T : Animal
{
    private List<T> items = new List<T>();

    // Додати елемент до списку
    public void Add(T item)
    {
        items.Add(item);
    }

    // Видалити елемент зі списку
    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    // Отримати всі елементи
    public IEnumerable<T> GetAll()
    {
        return items;
    }

    // Пошук тварини за іменем
    public T FindByName(string name)
    {
        return items.FirstOrDefault(item => item.Name == name);
    }

    public override string ToString()
    {
        return string.Join("\n", items);
    }
}

// Демонстрація роботи
public class Program
{
    public static void Main(string[] args)
    {
        var animalList = new GenericList<Animal>();

        // Додавання тварин
        animalList.Add(new Animal("Dog", 5));
        animalList.Add(new Animal("Cat", 3));
        animalList.Add(new Animal("Parrot", 2));

        // Вивід списку тварин
        Console.WriteLine("Animal List:");
        Console.WriteLine(animalList);

        // Пошук тварини за іменем
        var foundAnimal = animalList.FindByName("Cat");
        Console.WriteLine("\nFound Animal:");
        Console.WriteLine(foundAnimal);

        // Видалення тварини
        animalList.Remove(foundAnimal);
        Console.WriteLine("\nAnimal List after removal:");
        Console.WriteLine(animalList);
    }
}
