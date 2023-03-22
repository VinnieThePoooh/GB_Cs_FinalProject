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
System.Console.WriteLine("Введите значения через пробел");

string[] array = Console.ReadLine()!.Split();
int len  = FillLen(array);
System.Console.WriteLine(len);

