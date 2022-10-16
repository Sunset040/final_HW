// Код проекта
string[] arString = {"Mouse", "Cat", "Dog","Pie","pineapple", "tea"};
int count = arString.Length;

string[] arStringLite = new string[] {};

for (int i = 0; i < count; i++)
{
    if (arString[i].Length <= 3){
        Console.WriteLine(arString[i]);
    }
}
Console.WriteLine("--------------------------------");
Console.WriteLine("Result: ");
for (int i = 0; i < arStringLite.Length; i++) {
    Console.Write($"{arStringLite[i]}, ");
}