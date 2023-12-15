
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
GetResult(text);