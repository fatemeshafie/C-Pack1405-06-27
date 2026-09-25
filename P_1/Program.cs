Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.WriteLine($"Thanks {name}!");

Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine());

int years = 100 - age;

Console.WriteLine($"You are {years} years away from being 100 years old.");

if (years < 50)
{
    Console.WriteLine("Hurry up! Time is running out!");
}
else
{
    Console.WriteLine("You have time!");
}


// Phone Number
Console.Write("What is your phone number? ");
string phoneNumber = Console.ReadLine();

if (string.IsNullOrWhiteSpace(phoneNumber))
{
    Console.WriteLine("Phone number cannot be empty.");
}
else
{
    phoneNumber = phoneNumber.Trim();

    // +98xxxxxxxxxx → 09xxxxxxxxxx
    if (phoneNumber.StartsWith("+98"))
    {
        phoneNumber = "0" + phoneNumber.Substring(3);
    }
    // 9xxxxxxxxx → 09xxxxxxxxx
    else if (phoneNumber.StartsWith("9"))
    {
        phoneNumber = "0" + phoneNumber;
    }

    // Check length
    if (phoneNumber.Length > 11)
    {
        Console.WriteLine("Phone number cannot be more than 11 digits.");
    }
    else
    {
        Console.WriteLine($"Your phone number is: {phoneNumber}");

        Console.Write("Is this correct? (yes/no): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() =="yes")
        {
            Console.WriteLine("Thanks!");
        }
        else
        {
            Console.WriteLine("Please enter your phone number again.");
        }
    }
   
}
