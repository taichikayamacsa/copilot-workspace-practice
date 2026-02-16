Console.WriteLine("1つ目の数値を入力してください:");
string? input1 = Console.ReadLine();

if (!double.TryParse(input1, out double num1))
{
    Console.WriteLine("🙅");
    return;
}

Console.WriteLine("2つ目の数値を入力してください:");
string? input2 = Console.ReadLine();

if (!double.TryParse(input2, out double num2))
{
    Console.WriteLine("🙅");
    return;
}

Console.WriteLine("演算子を入力してください (+, -, *, /):");
string? operatorInput = Console.ReadLine();

switch (operatorInput)
{
    case "+":
        {
            double result = num1 + num2;
            Console.WriteLine($"結果: {num1} + {num2} = {result}");
            break;
        }
    case "-":
        {
            double result = num1 - num2;
            Console.WriteLine($"結果: {num1} - {num2} = {result}");
            break;
        }
    case "*":
        {
            double result = num1 * num2;
            Console.WriteLine($"結果: {num1} * {num2} = {result}");
            break;
        }
    case "/":
        {
            if (num2 == 0)
            {
                Console.WriteLine("0で割ることはできません");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($"結果: {num1} / {num2} = {result}");
            }
            break;
        }
    default:
        Console.WriteLine("無効な演算子です");
        break;
}
