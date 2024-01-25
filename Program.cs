using System;

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Knight", 175, 4, 2, 5, 3, 2);
        Player player2 = new Player("Rogue", 125, 3, 3, 2, 3, 5);
        Player player3 = new Player("Mage", 100, 1, 5, 1, 5, 2);
        Enemy enemy1 = new Enemy("Goblin", 75, 3, 1, 3, 3, 4);
        Enemy enemy2 = new Enemy("Orc", 125, 4, 3, 4, 2, 3);
        Enemy enemy3 = new Enemy("Demon", 200, 4, 5, 5, 4, 1);
    
    }
}