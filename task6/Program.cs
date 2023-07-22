Console.WriteLine("We're going to check if your number is even. Type your number: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;

if (b==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}