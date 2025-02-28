
internal class Program
{
    static void Main(string[] args)
    {
        Stack<char> stack = new Stack<char>();
        string userString = Console.ReadLine();
        bool flag = true;
        for (int i = 0; i < userString.Length; i++)
        {
            char elem = userString[i];
            if (elem == '(' || elem == '[' || elem == '{')
            {
                stack.Push(elem);
            }
            if (elem == ')' || elem == '}' || elem == ']')
            {
                if (stack.Count == 0)
                {
                    flag=false;
                    Console.WriteLine("Пустой стек");
                    break;
                }
                else
                {
                    char topElem = stack.Peek();
                    if ((elem == ')' && topElem == '(') || (elem == ']' && topElem == '[') || (elem == '}' && topElem == '{'))
                    {
                        stack.Pop();
                    }
                }
            }
        }
        if (stack.Count == 0 && flag == true)
        {
            Console.WriteLine("скобки расставленны верно");
        }
        else{
            Console.WriteLine("Cкобки расставленны неверно");
        }
    }
}