// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}
int CountElemsLessThen(string[] array, int param)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= param)
            counter++;
    return counter;
}
string[] SelectLessStr(string[] array, int param)
{
    string[] arrOut = new string[CountElemsLessThen(array, param)];
    int newCounter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            arrOut[newCounter++] = array[i];
    return arrOut;
}



Console.Write("Введите несколько слов, разделяя пробелами: ");
string? inputStr = Console.ReadLine();                         
Console.WriteLine();                                            

if (inputStr != null)                                           
{
    string[] arrayIn = inputStr.Split(' ');                       

    PrintArray(arrayIn);                                        

    string[] less3str = SelectLessStr(arrayIn, 3);              

    PrintArray(less3str);                                       
}
else
    Console.Write("Слова не были введены!");