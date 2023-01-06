// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello”, "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine();
String[] arrayStr1 = { "hello", "2", "world", ":-)" };
printArr(arrayStr1);
Console.Write(" -> ");
printStr(arrayStr1);
Console.WriteLine(); Console.WriteLine();
String[] arrayStr2 = { "1234", "1567", "-2", "computer science" };
printArr(arrayStr2);
Console.Write(" -> ");
printStr(arrayStr2);
Console.WriteLine(); Console.WriteLine();
String[] arrayStr3 = { "Russia", "Denmark", "Kazan" };
printArr(arrayStr3);
Console.Write(" -> ");
printStr(arrayStr3);
Console.WriteLine();

void printArr(String[] strArr)
{

    Console.Write("[");
    for (int i = 0; i < strArr.Length; i++)
    {

        Console.Write($"\"{strArr[i]}\", ");

    }
    Console.Write("]");
}

void printStr(String[] strArr)
{

    Console.Write("[");
    bool fl = false;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= 3)
        {
            if(fl) Console.Write(", ");
            fl = true;
            Console.Write($"\"{strArr[i]}\"");
        }
    }
    Console.Write("]");
}
