using System;

// 1.
Dog myDog = new("초코", 3);
myDog.Bark();
Console.WriteLine();

// 2.
Monster monster1 = new();
var monster2 = new Monster();
Console.WriteLine(monster1);
Console.WriteLine(monster2);
Console.WriteLine();

// 3.
var calculator = new Calculator();
calculator.Add(3, 5);
calculator.Multiply(4, 6);
Console.WriteLine();

// 4.
Counter.Increment();
Counter.Increment();
Counter.Increment();
Counter.Reset();
Console.WriteLine();

// 5.
GameManager.ShowStatus();
GameManager gm = new GameManager();
gm.Greet();
Console.WriteLine();

// 6.
Greeting.SayHello();
Farewell.Wave();

Greeting greeting = new Greeting();
greeting.SayGoodbye();
Farewell farewell = new Farewell();
farewell.Bow();
Console.WriteLine();

// 7.
Item item = new Item();
Console.WriteLine(item);
Console.WriteLine();

// 8.
Item8 item8 = new Item8();
Console.WriteLine(item8);
Console.WriteLine();

// 9.
Player player1 = new("전사", 10, 200);
Player player2 = new("마법사", 8, 120);
Console.WriteLine(player1);
Console.WriteLine(player2);
Console.WriteLine();

// 10.
Enemy[] enemies = new Enemy[3];
enemies[0] = new Enemy("고블린", 50);
enemies[1] = new Enemy("오크", 100);
enemies[2] = new Enemy("드래곤", 500);

for(int i = 0;  i < enemies.Length; i++)
{
    enemies[i].ShowInfo();
}

Console.WriteLine();

// 11.
Item11[] items = new Item11[3]
{
    new Item11 { Name = "검", Price = 500 },
    new Item11 { Name = "방패", Price = 300 },
    new Item11 { Name = "포션", Price = 50 }
};

foreach (Item11 i in items)
{
    Console.WriteLine(i);
}

Console.WriteLine();

// 12.
Character ch1 = new Character();
ch1.Name = "홍길동";
ch1.Job = "전사";
ch1.Level = 1;

Character ch2 = new Character
{
    Name = "이순신",
    Job = "궁수",
    Level = 5
};

Console.WriteLine(ch1);
Console.WriteLine(ch2);
Console.WriteLine();

// 13.
Student[] students = new Student[3]
{
    new Student { Name = "김철수", Score = 85 },
    new Student { Name = "이영희", Score = 92 },
    new Student { Name = "박민수", Score = 78 }
};

foreach (Student s in students)
{
    Console.WriteLine(s);
}

// 13.
class Student
{
    public string Name;
    public int Score;

    public override string ToString()
    {
        return $"{Name}: {Score}점";
    }
}

// 12.
class Character
{
    public string Name;
    public int Level;
    public string Job;

    public override string ToString()
    {
        return $"{Name} - {Job} Lv.{Level}";
    }
}

// 11.
class Item11
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name}: {Price}골드";
    }
}

// 10.
class Enemy
{
    string Name;
    int Health;

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP {Health}");
    }
}

// 9.
class Player
{
    string Name;
    int Level;
    int Health;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public override string ToString()
    {
        return $"[{Level}레벨] {Name} (HP: {Health})";
    }
}

// 8.
class Item8
{
    string Name = "포션";
    int Price = 100;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}

// 7.
class Item
{
    string Name = "포션";
    int Price = 100;
}

// 6.
class Greeting
{
    public static void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

class Farewell
{
    public static void Wave()
    {
        Console.WriteLine("(손을 흔든다)");
    }

    public void Bow()
    {
        Console.WriteLine("(인사한다)");
    }
}

// 5.
class GameManager
{
    static int TotalPlayers = 10;

    string PlayerName = "홍길동";

    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }

    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}

// 4.
class Counter
{
    static int Count;

    static public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }

    static public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }
}

// 3.
class Calculator
{
    public void Add(int x, int y)
    {
        Console.WriteLine($"합계: {x + y}");
    }

    public void Multiply(int x, int y)
    {
        Console.WriteLine($"곱: {x * y}");
    }
}

// 2.
class Monster
{
    string Name;
}

// 1.
class Dog
{
    string Name;
    int Age;

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}