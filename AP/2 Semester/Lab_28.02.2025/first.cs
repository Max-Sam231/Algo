internal class Program
{
// На стек:
// На вход подается запись, в которой идут числовые значения и знаки(*, +, -, /)(разделение между элементами - пробел)
// Запись представляет выражение записанное в постфиксной польской записи(сначала операнды, а потом операции). 
// Необходимо с помощью стека вычислить результат выражения.
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        string userString = Console.ReadLine();
        string[] elemArray = userString.Split(' ');
        for (int i = 0; i < elemArray.Length; i++)
        {
            string elem = elemArray[i];
            if ("+-/*".Contains(elem))
            {
                if (stack.Count >= 2)
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();
                    int tempRes = 0;
                    if (elem == "+") { tempRes = num1 + num2; }
                    if (elem == "-") { tempRes = num1 - num2; }
                    if (elem == "*") { tempRes = num1 * num2; }
                    if (elem == "/")
                    {
                        if (num2 != 0) { tempRes = num1 / num2; }
                        else
                        {
                            Console.WriteLine("Попытка деления на ноль");
                            break;
                        }
                    }

                    stack.Push(tempRes);
                }
            }
            else
            {
                stack.Push(Convert.ToInt32(elemArray[i]));
            }
        }
        if (stack.Count == 1)
        {
            Console.WriteLine("{0}", string.Join(",", stack));
        }
        else
        {
            Console.WriteLine("Неправильное выражение");
        }
    }
}
