class Program {
    static void Main() {
        //Ввод исходного массива с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую");
        string input = Console.ReadLine();
        string[] initialArray = (input ?? "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
        //Фильтрация массива
        string[] filteredArray = FilterStrings(initialArray);
        //Вывод отфильтрованного массива
        Console.WriteLine("Отфильтрованный массив: ");
        Console.WriteLine(string.Join(", ", filteredArray));
    }
    //Метод для фильтрации массива
    static string[] FilterStrings(string[] array) {
        if(array == null || array.Length == 0){
            return new string[0];
        }
        List<string> result = new List<string>();
        foreach (string str in array){
            if (str.Length <= 3){
                result.Add(str);
            }
        }
        return result.ToArray();
    }
}