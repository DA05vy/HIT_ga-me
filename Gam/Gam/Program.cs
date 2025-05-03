using System;
using System.Collections.Generic;
namespace Gam;

public abstract class Character
{
    public int PosX { get; set; }
    public int PosY { get; set; }
    public int Damage { get; set; }
    public int RangeAttack { get; set; }
    
    public Character(int posX, int posY, int damage, int rangeAttack)
    {
        PosX = posX;
        PosY = posY;
        Damage = damage;
        RangeAttack = rangeAttack;
    }
    
    public virtual void Move(char direction = ' ')
    {
        switch (direction)
        {
            case 'W': PosY++; break;
            case 'S': PosY--; break;
            case 'D': PosX++; break;
            case 'A': PosX--; break;
            default: break;
        }
    }

    public virtual void TakeDamage(int damage)
    {
        Damage -= damage;
    }

    public virtual Character CheckRangeAttack(Tile[,] grid)
    {
        for (int x = PosX - RangeAttack; x <= PosX + RangeAttack; x++)
        {
            for (int y = PosY - RangeAttack; y <= PosY + RangeAttack; y++)
            {
                if (x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1))
                {
                    var tile = grid[x, y];
                    if (tile.Character != null && tile.Character != this)
                    {
                        return tile.Character;
                    }
                }
            }
        }
        return null;
    }
    
    public void Attack(Tile[,] grid)
    {
        Enemy target = CheckRangeAttack(grid) as Enemy;
        if (target != null)
        {
            target.TakeDamage(Damage);
        }
    }
}

public class Enemy : Character
{
    public Enemy(int posX, int posY, int damage, int rangeAttack) : base(posX, posY, damage, rangeAttack)
    {
    }

    public void RandomMove()
    {
        Random rand = new Random();
        char[] directions = {'W', 'S', 'D', 'A'};
        Move(directions[rand.Next(directions.Length)]);
    }
}

public class Player : Character
{
    public Weapon CurrentWeapon { get; private set; }
    public Player(int posX, int posY) 
        : base(posX, posY, damage: 15, rangeAttack: 2, health: 100)
    {
        // Randomly select a weapon at game start
        CurrentWeapon = GenerateRandomWeapon();
    }

    private Weapon GenerateRandomWeapon()
    {
        Weapon[] weapons = new[]
        {
            new Weapon("Sword", 15, 1),
            new Weapon("Bow", 10, 3),
            new Weapon("Axe", 20, 1)
        };

        Random random = new Random();
        return weapons[random.Next(weapons.Length)];
    }
}

public class Weapon
{
    private string Name { get; }
    private int Attack { get; }
    private int RangeAttack { get; }
    public Weapon(string name, int attack, int rangeAttack)
    {
        Name = name;
        Attack = attack;
        RangeAttack = rangeAttack;
    }
}

public class Tile
{
    public Character Character { get; set; }
    public int PosX { get; }
    public int PosY { get; }

    public Tile(int posX, int posY)
    {
        PosX = posX;
        PosY = posY;
        Character = null;
    }

    public bool IsOccupied()
    {
        return Character != null;
    }
}

public class GridManager
{
    public int xWide { get; }
    public int yHigh { get; }
    public List<Enemy> Enemies { get; set; }
    public Player Player { get; set; }
    public Tile[,] Grid { get; set; }

    public void SpawnTile(int x, int y)
    {
        Grid[x,y] = new Tile(x, y);
    }

    public void UpdateGrid()
    {
        Grid = new Tile[xWide, yHigh];
    }
}

public class GameManager
{
    public int xWide { get; set; }
    public int yHigh { get; set; }
    public List<Enemy> Enemies { get; set; }
    public Player Player { get; set; }
    public string Turn { get; set; }
    public void StartBattle()
    {
        
    }

    public void SpawnEntity()
    {
        
    }

    public void TurnPlayer()
    {
        
    }

    public void TurnEnemy()
    {
        
    }

    public void CheckWinOrLose()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}