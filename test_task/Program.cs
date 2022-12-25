// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
Console.WriteLine("Введите число элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива:");
string [] array = new string[n];

for(int i=0;i<array.Length; i++)
{
  array[i] = Console.ReadLine();
}

Console.WriteLine($"[" + string.Join(", ", array) +"]"); 


string [] array2 = new string[array.Length];

for(int i = 0; i < array.Length; i++)
{
    int limit = 3;
    if(array[i].Length <= limit)
    {
        array2[i]=array[i];
    }    
}

Console.WriteLine(string.Join(" ", array2));