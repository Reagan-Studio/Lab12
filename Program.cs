using Lab12;



////номер3---------------------------------------------------------------------------------------------------------------------------------
////a1
//MyQueue<char> queue = new MyQueue<char>();

//Console.WriteLine("Введите строку для обработки:");
//string input = Console.ReadLine(); //EAS * Yes * QUE * * * stop * * * IO * to * N *

//foreach (char c in input)
//{
//    if (c >= 65 && c <= 90)
//    {
//        queue.Enqueue(c);
//    }
//    else if (c == '*')
//    {
//        if (!queue.IsEmpty)
//        {
//            Console.Write(queue.Dequeue() + " ");
//        }
//    }
//}


////a2
//Queue<char> queue2 = new Queue<char>();

//Console.WriteLine("\n\nВведите строку для обработки:");
//string input2 = Console.ReadLine();

//foreach (char c in input2)
//{
//    if (char.IsUpper(c))
//    {
//        queue2.Enqueue(c);
//    }
//    else if (c == '*')
//    {
//        if (queue2.Count > 0)
//        {
//            Console.Write(queue2.Dequeue() + " ");
//        }
//    }
//}


////б1
//Queue<string> queue3 = new Queue<string>(File.ReadAllLines(@"..\..\..\basedir\lab12.txt"));

//int maxIndex = 0;
//int maxLength = 0;
//for (int i = 0; i < queue3.Count; i++)
//{
//    string line = queue3.Dequeue();
//    if (line.Length > maxLength)
//    {
//        maxLength = line.Length;
//        maxIndex = i;
//    }
//    queue3.Enqueue(line);
//}


//Queue<string> tempQueue = new Queue<string>();
//for (int i = 0; i < maxIndex; i++)
//{
//    tempQueue.Enqueue(queue3.Dequeue());
//}
//string maxLine = queue3.Dequeue();
//while (queue3.Count > 0)
//{
//    tempQueue.Enqueue(queue3.Dequeue());
//}
//queue3.Enqueue(maxLine);
//while (tempQueue.Count > 0)
//{
//    queue3.Enqueue(tempQueue.Dequeue());
//}


//while (queue3.Count > 0)
//{
//    Console.WriteLine(queue3.Dequeue());
//}













////номер2-----------------------------------------------------------------------------------------------------------------------------------------
//static string CheckBrackets(string str)
//{
//    MyStack<char> stack = new MyStack<char>();
//    List<int> list = new List<int>();
//    int index = -1;

//    for (int i = 0; i < str.Length; i++)
//    {
//        char c = str[i];

//        if (c == '(' || c == '[' || c == '{')
//        {
//            stack.Push(c);
//            list.Add(i);
//            index = i;
//        }
//        else if (c == ')' || c == ']' || c == '}')
//        {
//            if (stack.IsEmpty)
//            {
//                return (i + 1).ToString();
//            }

//            char top = stack.Pop();
//            if (index != -1)
//            {
//                list.Remove(index);
//            }

//            if ((top == '(' && c != ')') || (top == '[' && c != ']') || (top == '{' && c != '}'))
//            {
//                return (i + 1).ToString();
//            }
//        }
//    }

//    if (stack.IsEmpty)
//    {
//        return "YES";
//    }
//    else
//    {
//        return (list[0] + 1).ToString();
//    }
//}


//try
//{
//    string str = "([](){([])})";
//    Console.WriteLine(CheckBrackets(str)); //y

//    str = "()[]}";
//    Console.WriteLine(CheckBrackets(str)); //5

//    str = "{}([]";
//    Console.WriteLine(CheckBrackets(str)); //3

//    str = "[]([]";
//    Console.WriteLine(CheckBrackets(str));//3

//    str = "foo(bar[i);";
//    Console.WriteLine(CheckBrackets(str)); //10
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}










////номер1-------------------------------------------------------------------------------------------------------------------------------------
//try
//{
//    //a,б
//    using (StreamReader reader = new StreamReader(@"..\..\..\basedir\lab12.txt")) {
//        MyStack<string> stack = new MyStack<string>();

//        string line;

//        while ((line = reader.ReadLine()) != null)
//        {
//            stack.Push(line);
//        }

//        Console.WriteLine(stack.ToString());

//    }


//    //в
//    using (StreamReader reader = new StreamReader(@"..\..\..\basedir\lab12.txt"))
//    {
//        MyStackMinMaxComparator<string, IComparer<string>> stack2 = new MyStackMinMaxComparator<string, IComparer<string>>(Comparer<string>.Create((s1, s2) => s1.Length - s2.Length));

//        string line;

//        while ((line = reader.ReadLine()) != null)
//        {
//            stack2.Push(line);
//        }

//        Console.WriteLine($"\nСамая короткая строка: {stack2.GetMin()}");
//        Console.WriteLine($"Номер строки в файле: {stack2.Minindex}");
//        Console.WriteLine($"Длина строки: {stack2.GetMin().Length}");

//    }


//    //г
//    using (StreamReader reader = new StreamReader(@"..\..\..\basedir\lab12.txt"))
//    {
//        var stack = new Stack<string>();

//        string line;

//        while ((line = reader.ReadLine()) != null)
//        {
//            stack.Push(line);
//        }


//        int minLength = int.MaxValue;
//        int minIndex = -1;

//        int index = 0;
//        foreach (string str in stack)
//        {
//            if (str.Length < minLength)
//            {
//                minLength = str.Length;
//                minIndex = index;
//            }
//            index++;
//        }

//        Console.WriteLine($"\nСамая короткая строка имеет индекс {minIndex} и длину {minLength}: '{stack.ToArray()[minIndex]}'");

//    }


//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}







