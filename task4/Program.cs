Console.WriteLine("Type a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(max<a)
{
   max = a;
}
if(max<b)
{
    max = b;
}
if(max<c)
{
    max = c;
}    

Console.WriteLine("max = " + max);