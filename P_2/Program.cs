using System;
using System.Text.RegularExpressions;

// ==========================================
// Mock Data
// ==========================================

string mockName1 = "Fateme";
string mockLastName1 = "Shafiei";
string mockNationalCode1 = "0012345678";
string mockMobile1 = "09123456789";
string mockCard1 = "6037991234567890";

string mockName2 = "Ali";
string mockLastName2 = "Ahmadi";
string mockNationalCode2 = "0023963004";
string mockMobile2 = "9123456789";
string mockCard2 = "5892101234567890";

string mockName3 = "Sara";
string mockLastName3 = "Mohammadi";
string mockNationalCode3 = "1234567890";
string mockMobile3 = "+989123456789";
string mockCard3 = "6104331234567890";


// ==========================================
// Name
// ==========================================

Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.Write("What is your last name? ");
string lastName = Console.ReadLine();

Console.WriteLine($"Hello {name} {lastName}!");


// ==========================================
// Birth Date & Age
// ==========================================

Console.Write("Enter your birth year: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Enter your birth month: ");
int birthMonth = int.Parse(Console.ReadLine());

Console.Write("Enter your birth day: ");
int birthDay = int.Parse(Console.ReadLine());

DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
DateTime today = DateTime.Today;

int age = today.Year - birthDate.Year;

if (today < birthDate.AddYears(age))
{
    age--;
}

Console.WriteLine($"You are {age} years old.");


// ==========================================
// Distance to 100
// ==========================================

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


// ==========================================
// National Code
// ==========================================

Console.Write("Enter your national code: ");
string nationalCode = Console.ReadLine();

if (!Regex.IsMatch(nationalCode, @"^\d{10}$"))
{
    Console.WriteLine("National code must contain exactly 10 digits.");
}
else
{
    int sum = 0;

    for (int i = 0; i < 9; i++)
    {
        sum += int.Parse(nationalCode[i].ToString()) * (10 - i);
    }

    int remainder = sum % 11;

    int controlDigit = int.Parse(nationalCode[9].ToString());

    bool validNationalCode;

    if (remainder < 2)
    {
        validNationalCode = controlDigit == remainder;
    }
    else
    {
        validNationalCode = controlDigit == 11 - remainder;
    }

    if (validNationalCode)
    {
        Console.WriteLine("National code is valid.");
    }
    else
    {
        Console.WriteLine("National code is invalid.");
    }
}


// ==========================================
// Mobile Number
// ==========================================

Console.Write("Enter your mobile number: ");
string mobile = Console.ReadLine();

if (string.IsNullOrEmpty(mobile))
{
    Console.WriteLine("Mobile number cannot be empty.");
}
else
{
    mobile = mobile.Trim();

    // +989123456789 -> 09123456789
    if (mobile.StartsWith("+98"))
    {
        mobile = "0" + mobile.Substring(3);
    }

    // 9123456789 -> 09123456789
    else if (mobile.StartsWith("9"))
    {
        mobile = "0" + mobile;
    }

    // Check length
    if (mobile.Length != 11)
    {
        Console.WriteLine("Mobile number must contain 11 digits.");
    }

    // Check first two digits
    else if (!mobile.StartsWith("09"))
    {
        Console.WriteLine("Mobile number must start with 09.");
    }

    else
    {
        Console.WriteLine($"Clean mobile number: {mobile}");

        Console.Write("Is this correct? (yes/no): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            Console.WriteLine("Thanks!");
        }
        else
        {
            Console.WriteLine("Please enter your phone number again.");
        }
    }
}


// ==========================================
// Bank Card
// ==========================================

Console.Write("Enter your bank card number: ");
string cardNumber = Console.ReadLine();

if (string.IsNullOrEmpty(cardNumber))
{
    Console.WriteLine("Card number cannot be empty.");
}
else if (cardNumber.Length != 16)
{
    Console.WriteLine("Bank card number must contain 16 digits.");
}
else
{
    string bank = cardNumber.Substring(0, 6);

    string bankName;

    switch (bank)
    {
        case "603799":
            bankName = "Bank Melli";
            break;

        case "589210":
            bankName = "Bank Sepah";
            break;       

        case "603770":
            bankName = "Bank Keshavarzi";
            break;

        case "628023":
            bankName = "Bank Maskan";
            break;

        case "627760":
            bankName = "Post Bank";
            break;

        case "610433":
            bankName = "Bank Mellat";
            break;

        case "621986":
            bankName = "Bank Saman";
            break;

        case "622106":
            bankName = "Bank Parsian";
            break;

        case "639347":
            bankName = "Bank Pasargad";
            break;

        default:
            bankName = "Unknown Bank";
            break;
    }

    Console.WriteLine($"Bank: {bankName}");
}


// ==========================================
// Finish
// ==========================================

Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("Information completed!");
Console.WriteLine($"Name: {name} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Mobile: {mobile}");
Console.WriteLine($"BankName: {bankName}");
Console.WriteLine("================================");

Console.ReadKey();