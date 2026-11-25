//Текстовая RPG-битва(ООП, наследование, полиморфизм)
//Разработать консольную пошаговую игру, в которой игрок сражается с монстром.

//Пример работы программы
//=== Игра 'Битва с монстром' ===
//Введите имя вашего персонажа:
//Артур
//Битва начинается! Артур против Злобный Гоблин!
//Ваш ход:
//1  Атаковать / 2 - Использовать зелье здоровья
//1
//Артур наносит 5 урона Злобный Гоблин!
//Ход Злобный Гоблин...
//Злобный Гоблин наносит 3 урона Артур!
//Текущее состояние:
//Артур: 27 HP
//Злобный Гоблин: 15 HP...

//Требования к реализации

//A.Базовый класс Character
//Должен содержать:
//    Автосвойства:
//        Name(имя персонажа),
//        Health(здоровье),
//        Damage(урон за атаку).
//    Конструктор, инициализирующий эти свойства.
//    Виртуальный метод Attack(Character target), уменьшающий здоровье цели (target)
//    на значение Damage и выводящий информацию об атаке.
//    Свойство IsAlive, возвращающее true, если здоровье > 0.

//B. Класс игрока Player (наследуется от Character)
//Дополнительно должен:
//    Иметь 3 зелья здоровья, каждое восстанавливает 10 HP.
//    Содержать метод UseHealthPotion() для использования зелья (увеличивает здоровье,
//    уменьшает количество зелий).
//    Наносить фиксированный урон (5 единиц).

//C. Класс монстра Monster (наследуется от Character)
//Должен:
//    Наносить случайный урон (от 1 до 6) при каждой атаке.
//    Иметь имя "Злобный Гоблин" и стартовое здоровье 20 HP.

//D. Логика игры (Game)
//    Инициализация:
//        Запрос имени игрока.
//        Создание объектов Player и Monster.
//    Пошаговый бой:
//        Ход игрока: выбор действия(атака или использование зелья).
//        Ход монстра: автоматическая атака с случайным уроном.
//        Отображение текущего состояния (HP игрока и монстра).
//    Завершение игры при победе одного из персонажей.
//    Возможность сыграть снова.
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HW_13_Task_05
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== A Game 'Battle with the monster' ======");
            Console.WriteLine("Enter your character’s name: ");
            string name = Console.ReadLine() ?? "player1";
            Player player_1 = new Player(name, 100); // какое дб health ?????
            Monster monster_1 = new Monster(6); // какое дб damage ?????

            Console.WriteLine("=== === === === === === === === === === === ===");
            Console.WriteLine("Current state:");
            player_1.PrintInfo();
            monster_1.PrintInfo();
            Console.WriteLine("=== === === === === === === === === === === ===");

            Game game = new Game(player_1, monster_1);
            game.Start();
        }
    }
}

public class Character
{
    protected string _name;
    public string Name { get { return _name; } }
    public int Health { get; set; }
    public virtual int Damage { get; set; }

    public bool IsAlive
    {
        get
        {
            if (Health > 0) return true;
            else return false;
        }
    }

    public Character(string name, int health, int damage)
    {
        _name = name;
        Health = health; Damage = damage;
    }

    public virtual void Attack(Character target)
    {
        int healthBeforeAttack = target.Health;
        target.Health -= Damage;
        Console.WriteLine($"Attack has occured!");
        // Health before attack: {healthBeforeAttack}. Health after attack {target.Health}");
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Character {Name}: {Health} HP");
        //Console.WriteLine($"{Name} is alive? {(IsAlive ? "YES" : "NO")}");
        Console.WriteLine($"{Name} is {(IsAlive ? "ALIVE" : "DEAD")}");
    }
}

public class Player : Character
{
    private const int healthPointsRestoration = 10;
    private const int fixedDamage = 5;

    private int _potionCount = 3;

    public Player(string name, int health) : base(name, health, fixedDamage) { }


    public void UseHealthPotion()
    {
        if (_potionCount > 0)
        {
            Health += healthPointsRestoration;
            _potionCount--;

            Console.WriteLine($"Healing! Potions left: {_potionCount}");
        }
        else
        {
            Console.WriteLine("No more potions left.");
        }
    }

    public override void Attack(Character target)
    {
        // target.Health -= Damage;
        base.Attack(target);
        Console.WriteLine($"{Name} deals {fixedDamage} damage to {target.Name}!");
    }

    //public override void PrintInfo()
    //{
    //    base.PrintInfo();
    //    Console.WriteLine($"{Name} is alive? {(IsAlive ? "YES" : "NO")}");
    //}
}

public class Monster : Character
{
    private Random rnd = new Random();
    private const string monsterName = "Angry Goblin";
    private const int monsterHealth = 20;

    public override int Damage { get => rnd.Next(1, base.Damage + 1); set => base.Damage = value; }
    public Monster(int damage) : base(monsterName, monsterHealth, damage) { }

    //public override void Attack(Character target)
    //{
    //    Random rnd = new Random();
    //    int rndDamage = rnd.Next(1, Damage + 1);
    //    target.Health -= rndDamage;
    //}
}


public class Game
{
    private Player _player;
    private Character _monster;

    public Game(Player player, Character monster)
    {
        _player = player; _monster = monster;
    }

    public bool PlayRound()
    {
        // bool stopTheGame = false;

        Console.WriteLine($"The battle begins! {_player.Name} vs. {_monster.Name}!");
        Console.WriteLine("Your turn:");
        Console.WriteLine("Choose action for player: 1 - attack / 2 - healing / 3 - quit the game.");


        int playerAction = 0;

        while (playerAction != 1 && playerAction != 2 && playerAction != 3)
        {
            if (!int.TryParse(Console.ReadLine(), out playerAction))
            {
                Console.WriteLine("Please enter a valid number! Number must be 1, 2 or 3!");
                continue;
            }
        }

        if (playerAction == 1)
        {
            _player.Attack(_monster);
        }
        else if (playerAction == 2)
        {
            _player.UseHealthPotion(); 
        }
        else if (playerAction == 3)
        {
            return true;
        }
        if (_player.Health <= 0 || _monster.Health <= 0)
        {
            return true;
        }
        Console.WriteLine($"It is {_monster.Name}'s turn ... ");
        _monster.Attack(_player);

        return false;
    }

    public void Start()
    {
        while (true)
        {

            bool stopTheGame = PlayRound();
            ShowGameInfo();
            if (stopTheGame)
            {
                return;
            }
        }
    }

    public void ShowGameInfo()
    {
        Console.WriteLine("=== === === === === === === === === === === ===");
        Console.WriteLine("Current state:");
        _player.PrintInfo();
        _monster.PrintInfo();
        Console.WriteLine("=== === === === === === === === === === === ===");
    }
}