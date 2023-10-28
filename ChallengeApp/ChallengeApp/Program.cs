int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int[] results = new int[10];
foreach (var letter in letters)
{
    for (int i = 0; i < results.Length; i++)
    {
        int a = letter - '0';
        if (a == i)
        {
            results[i]++;
        }
    }
}

Console.WriteLine("Wyniki dla liczby: " + number);
for (int i = 0; i < results.Length; i++)
{
    Console.WriteLine(i + " => " + results[i]);
}