// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a number?");

string stringNum = Console.ReadLine();
int num = int.Parse(stringNum);

Console.WriteLine("You entered " + num + "!");


//int x = 3;
//int y = 5;

//int z = x+y;
//Console.WriteLine(z);

//'%' returns the remainder
//Console.WriteLine(4%2);
//Console.WriteLine(6%2);

//truth table
// && and
// || or

/*
if(name == "chris")
{
    Console.WriteLine("Hi Chris!");
}
else
{
    Console.WriteLine("You're not Chris!");
}
*/

int n = 1;

for(int i=1;i < num+1;i++)
{
    if(i%3!=0 && i%5!=0)
    {
        Console.WriteLine(i);
    }
    else if (i%3==0 && i%5==0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }
    else if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }
}