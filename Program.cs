﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Knight", 200, 5, 1, 4, 2, 2);
        Enemy enemy1 = new Enemy("Goblin", 120, 3, 2, 3, 3, 4);
        player1.DisplayStats();
        enemy1.DisplayStats();
    }
}