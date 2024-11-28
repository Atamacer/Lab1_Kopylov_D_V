using System;

public class Books
{
    public string name;
    public string author;
    public int year;
    public int sheets;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nАвтор: {author} \nГод выпуска: {year} \nЛисты: {sheets}");
    }
}

public class Bugs
{
    public string name;
    public int speed;
    public string food;
    public string livingEnvironment;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nСкорость: {speed} \nПища: {food} \nСреда обитания: {livingEnvironment}");
    }
}

public class Journals
{
    public string name;
    public int number;
    public string date;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nНомер: {number} \nДата выпуска: {date}");
    }
}

public class Cake
{
    public string name;
    public int weight;
    public int price;
    public int calories;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nВес: {weight} \nЦена: {price} \nКалории: {calories}");
    }
}

public class Products
{
    public string name;
    public string category;
    public int price;
    public int count;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nКатегория: {category} \nЦена: {price} \nКоличество: {count}");
    }
}

public class Plane
{
    public string name;
    public int capacity;
    public int range;
    public int maxSpeed;

    public void Info()
    {
        Console.WriteLine($"Название: {name} \nВместимость: {capacity} \nДальность: {range} \nМаксимальная скорость: {maxSpeed}");
    }
}

public class Student
{
    public string name;
    public int age;
    public int sleepHours;

    public void Info()
    {
        Console.WriteLine($"Имя: {name} \nВозраст: {age} \nКоличество часов сна: {sleepHours}");
    }

    public void addHour()
    {
        age++;
    }

    public void removeHour()
    {
        age--;
    }
}




