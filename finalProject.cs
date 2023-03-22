int FillLen(string[] array)
{
    int len = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i].Length<3 || array[i].Length==3)
        {
            len++;
        }
    }
    return len;
}

string[] ChangeArr (string[] array, int len)
{
    int j = 0;
    string[] array2 = new string[len];
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length<3 || array[i].Length==3)
        {
            array2[j]=array[i];
            j++;
        }
    }
    return array2;
}
System.Console.WriteLine("Введите значения через пробел");

string[] array = Console.ReadLine()!.Split();
int len  = FillLen(array);
string[] array2 = ChangeArr(array, len);
System.Console.WriteLine("["+string.Join(" ", array2)+"]");


