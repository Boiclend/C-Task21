// Разработать программу, выполняющую обработку строки. Обработка строки должна осуществляться посимвольно
// (использование функций форматированного вывода  scanf() и sscanf() не допускается).
// Найти сумму целых чисел, перечисленных в исходной строке через запятую. Ввод исходной строки осуществляется с клавиатуры.

void GetResult(string txt) {
    string[] nums = txt.Split(',');
    int summ = 0;
        for(int i = 0; i < nums.Count(); i ++)
        {
        summ += int.Parse(nums[i]);
        }
    Console.WriteLine($"summ = {summ}");
}

Console.WriteLine("Введите строку чисел ( числа отделяются друг от друга запятой ) : ");
string text = Console.ReadLine();
if(text == "") 
{
    Console.WriteLine("The input string '' was not in a correct format");
    return;
}
GetResult(text);