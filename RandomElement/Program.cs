﻿string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaway" };

Random rand = new Random();

int randomIndex = rand.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
