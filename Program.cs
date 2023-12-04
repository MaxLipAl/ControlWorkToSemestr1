//Урок 1. Контрольная работа
//Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

//Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] FilterStrings(string[] inputArray) //Метод для фильтрации строк
{
    int count = CountFilteredStrings(inputArray);
    string[] resultArray = CreateFilteredArray(inputArray, count);
    return resultArray;
}

int CountFilteredStrings(string[] inputArray) //// Метод для подсчета отфильтрованных строк
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateFilteredArray(string[] inputArray, int count)//// Метод для создания массива отфильтрованных строк
{
    string[] resultArray = new string[count];
    int resultIndex = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3 && !string.IsNullOrWhiteSpace(inputArray[i]))
        {
            resultArray[resultIndex] = inputArray[i];
            resultIndex++;
        }
    }
    return resultArray;
}

string ReadInput()// Метод для чтения входных данных
{
    Console.WriteLine("Введите строки, разделяйте их запятыми или пробелами:");
    return Console.ReadLine();
}


void PrintInputArray(string[] inputArray)// Метод для вывода массива строк
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"\"{inputArray[i]}\"");
        if (i < inputArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintResultArray(string[] resultArray) // Метод для вывода результата (отфильтрованных строк)
{
    Console.Write("[");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write($"\"{resultArray[i]}\"");
        if (i < resultArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string inputText = ReadInput();// Чтение входных данных
char[] separators = new char[] { ',', ' ' };// Определение разделителей для ввода (пробелы и запятые)
string[] inputArray = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);// Разбиваем входную строку на массив строк
string[] filteredStrings = FilterStrings(inputArray);// Фильтрация строк и получение результата
string result = string.Join(", ", filteredStrings);// Преобразование отфильтрованных строк в строку для вывода
// Вывод на экран
PrintInputArray(inputArray);
Console.Write(" -> ");
PrintResultArray(filteredStrings);


