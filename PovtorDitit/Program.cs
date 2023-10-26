string str = Console.ReadLine();
string numberStr = String.Empty;
string result = String.Empty;
foreach (char item in str)
{
    if(!result.Contains(item))
    {
        result = result + item;
    }    
}
foreach (char item in result)
{
    int count = 0;
    foreach (char symbol in str)
    {
        if (item == symbol)
        {
            count++;
        }
    }
    if (count > 1 && Char.IsDigit(item))
    {
        numberStr = numberStr + item;
    }
}
Console.WriteLine(numberStr);