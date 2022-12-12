// Задано n произвольных целых чисел (элементы массива). Определить, 
// является ли их расположение в массиве упорядоченным (т.е. по возрастанию или по убыванию) или неупорядоченным.

int[] Array (int length1)
{
int[] arr = new int [length1];
for (int i = 0; i < length1; i++)
{
    System.Console.WriteLine($"Write {i+1} number");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}
int[] ShowCheckArray (int[] array)
{
int i=0;
while ( array[i]==array[i+1])
{
    System.Console.Write($"{array[i]} ");
    i++;
}
    if (array[i] > array[i + 1])
    {
        while (i < array.Length)
        {
            if (array[i] > array[i+1])
            {
                System.Console.Write($"{array[i]} ");
            }
            if (array[i]==array[i+1])
            {
            while (array[i] == array[i + 1])
            {
                System.Console.Write($"{array[i]} ");
                i++;
            }
            }
            else if (array[i] < array[i+1])
            {
                System.Console.WriteLine("massive is not ordered");
                break;
            }
            else if (i+2 == array.Length)
            {
                System.Console.Write($"{array[i+1]} ");
                System.Console.WriteLine("massive is ordered");
                break;
            }
            i++;
        }
    }
    else if (array[i] < array[i + 1])
    {
        while (i < array.Length)
        {
            if (array[i] < array[i+1])
            {
                System.Console.Write($"{array[i]} ");
            }
            if (array[i]==array[i+1])
            {
            while (array[i] == array[i + 1])
            {
                System.Console.Write($"{array[i]} ");
                i++;
            }
            }
            
            else if (array[i] > array[i+1])
            {
                System.Console.WriteLine("massive is not ordered");
                break;
            }
            else if (i+2 == array.Length)
            {
                System.Console.Write($"{array[i+1]} ");
                System.Console.WriteLine("massive is ordered");
                break;
            }
            i++;
        }
    }
return array;
}
System.Console.WriteLine("Write length massive");
int length = Convert.ToInt32(Console.ReadLine());
ShowCheckArray(Array(length));



