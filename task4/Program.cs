// solved with array sort method, if you want to see the casual solution, check up the commit "ad6d73d" on the branch "task4"
Console.WriteLine("Type a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] max = {a, b, c};
Array.Sort(max);

Console.WriteLine("max = " + max[max.Length - 1]);
