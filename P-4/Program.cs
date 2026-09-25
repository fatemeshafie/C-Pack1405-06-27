Console.Write("How many Fibonacci numbers do you want? ");
int n = int.Parse(Console.ReadLine());

int first = 0;
int second = 1;

for (int i = 0; i < n; i++)
{
    Console.Write(first + " ");

    int next = first + second;

    first = second;
    second = next;
}