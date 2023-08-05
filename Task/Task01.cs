Console.WriteLine("Введите количество элементов массива: "); // Ввод количества элементов массива
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[arrayLength];

void FillArray(string[] array) // Метод для заполнения массива строк с клавиатуры
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива"); // Ввод элемента массива с клавиатуры
        array[i] = Console.ReadLine();
    }
}

string[] FilterStrings(string[] array) // Метод для фильтрации строк массива
{
    int filteredCount = 0; // Подсчет количества строк, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            filteredCount++;
    }
    string[] resultArray = new string[filteredCount]; // Создание нового массива с отфильтрованными строками
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}
void PrintArray(string[] array) // Метод для вывода на экран
{
    Console.Write("["); // Вывод на экран
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}'");
    }
    Console.Write("]");
}

FillArray(stringArray); // Заполнение массива с клавиатуры
PrintArray(FilterStrings(stringArray)); // Вывод результата фильтрации на экран