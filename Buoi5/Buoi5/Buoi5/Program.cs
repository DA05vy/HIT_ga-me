// Tính trừu tượng: Lớp trừu tượng Animal mô tả các đặc điểm chung của mọi động vật.
public abstract class Animal
{
    // Thuộc tính: Đóng gói thông tin về tên và tuổi.
    public string Name { get; private set; }
    public int Age { get; private set; }

    // Constructor để khởi tạo thông tin chung của động vật.
    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Phương thức trừu tượng: Các lớp con bắt buộc phải cài đặt.
    public abstract void Speak();

    // Phương thức cụ thể: Có thể dùng chung cho tất cả động vật.
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Tính kế thừa: Lớp Dog kế thừa từ Animal.
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Tính đa hình: Ghi đè phương thức Speak để định nghĩa hành vi cụ thể.
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof Woof!");
    }
}

// Tính kế thừa: Lớp Cat kế thừa từ Animal.
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Tính đa hình: Ghi đè phương thức Speak để định nghĩa hành vi cụ thể.
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

// Một lớp đặc biệt: Bird không chỉ có hành vi bay mà còn có hành vi kêu khác biệt.
public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Tweet Tweet!");
    }

    // Đóng gói: Một phương thức riêng của Bird.
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying!");
    }
}

// Chương trình chính
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo danh sách động vật (đa hình).
        Animal[] animals = new Animal[]
        {
            new Dog("Buddy", 3),
            new Cat("Whiskers", 2),
            new Bird("Tweety", 1)
        };

        // Lặp qua danh sách và gọi các phương thức.
        foreach (var animal in animals)
        {
            animal.ShowInfo(); // Thông tin chung của động vật.
            animal.Speak();    // Đa hình: Gọi phương thức Speak phù hợp với từng loại động vật.
            Console.WriteLine();
        }

        // Gọi phương thức riêng của Bird.
        Bird bird = new Bird("Sky", 4);
        bird.ShowInfo();
        bird.Speak();
        bird.Fly(); // Tính đóng gói: Phương thức chỉ thuộc về Bird.
    }
}