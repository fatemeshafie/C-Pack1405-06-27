// دریافت دو عدد

Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());


// بخش اول: آیا عدد اول بر عدد دوم بخش پذیر است؟

if (number2 != 0 && number1 % number2 == 0)
{
    Console.WriteLine($"{number1} is divisible by {number2}.");
}
else
{
    Console.WriteLine($"{number1} is not divisible by {number2}.");
}


// بخش دوم: آیا عدد وارد شده عدد اول است؟

bool isPrime = true;

if (number1 < 2)
{
    isPrime = false;
}
else
{
    for (int i = 2; i < number1; i++)
    {
        if (number1 % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine($"{number1} is a prime number.");
}
else
{
    Console.WriteLine($"{number1} is not a prime number.");
}


// بخش سوم: آیا عدد بر 3 بخش پذیر است؟

if (number1 % 3 == 0)
{
    Console.WriteLine($"{number1} is divisible by 3.");
}
else
{
    Console.WriteLine($"{number1} is not divisible by 3.");
}