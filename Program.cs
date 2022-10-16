// Код проекта
string[] arString = {"Mouse", "Cat", "Dog","Pie","pineapple", "tea"};
string[] arStringLite = new string[arString.Length];

int countItems = 0; 

// Пробегаемся по массиву и добавляем в новый массив слова с количеством символов меньше или равным 3
// путём подсчёта индекса удовлетворяющих условие элементов
for (int i = 0; i < arString.Length; i++)
{
    if (arString[i].Length <= 3){
        arStringLite[countItems] = arString[i];
        countItems += 1;
    }
}

// Выводим результат
Console.WriteLine("--------------------------------");
Console.WriteLine("Result: ");
for (int i = 0; i < countItems; i++) {
    Console.Write($"{arStringLite[i]} ");
}