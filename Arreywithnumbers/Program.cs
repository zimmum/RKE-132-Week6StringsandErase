int[] numbers = new int[10];
Random rand = new Random();

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");