int m;
Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine()!, out m);
string[] stringArray = new string[m];

void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine()!;
    }
}
string[] element(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            count++;
    }
    string[] rezult = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rezult[j] = stringArray[i];
            j++;
        }
    }
    return rezult;
}
void Print(string[] strArray)
{
    Console.Write("[");
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
    Console.Write("]");
}
array(stringArray);
Print(element(stringArray));
