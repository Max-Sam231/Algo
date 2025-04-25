// Дан файл с набором строк. 
// В каждой строке распологаются различные символы(цифры, буквы и т.д.). 
// Необходимо в выходной(новый) файл выдать только те строки, в которых имеется хотя бы одно четное число. 
// Числом будем считать набор цифр ограниченный другими символами(конец строки тоже символ)
internal class Program
{
    static void Main(string[] args)
    {
        string input = "input.txt";
        string output = "output.txt";
        string[] lines = File.ReadAllLines(input);
        List<string> outputLines = new List<string>();
        foreach (string line in lines)
        {
            if (containsEvenNum(line))
            {
                outputLines.Add(line);
            }
        }

        File.WriteAllLines(output, outputLines);
    }

    static bool containsEvenNum(string line)
    {
        bool isEven = false;
        string cur = "";
        char last;
        foreach (char n in line)
        {
            if (char.IsDigit(n))
            {
                cur += n;
            }
            else
            {
                if (!string.IsNullOrEmpty(cur))
                {
                    last = cur[cur.Length - 1];
                    if (last == '0' || last == '2' || last == '4' || last == '6' || last == '8')
                    {
                        isEven = true;
                        break;
                    }
                }
            }
        }
        if (!string.IsNullOrEmpty(cur))
        {
            last = cur[cur.Length - 1];
            if (last == '0' || last == '2' || last == '4' || last == '6' || last == '8')
            {
                isEven = true;
            }
        }

        return isEven;
    }
}