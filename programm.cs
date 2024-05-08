
using System
class Program {
    static void Main() {
        //Ввод исходного массива с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(',');
        //Фильтрация массива
        string[] filteredArray = FilterStrings(initialArray)
        //Вывод отфильтрованного массива
        Console.WriteLine("Отфильтрованный массив: ")
        foreach (string str in filteredArray){
            Console.WriteLine(str);
        }
    }
    //Метод для фильтрации массива
    static string[] FilterStrings(string[] array) {
        string[] result = new string[array.Length];
        int index = 0;
        foreach (string str in array){
            if(str <= 3){
                result[index] = str;
                index++;
            }
        }
        //Создание нового массива размером соответствующим количеству отвильтрованных элементов
        string[] filteredResult = new string[index];
        Array.Copy(result, filteredResult, index);
    }
}