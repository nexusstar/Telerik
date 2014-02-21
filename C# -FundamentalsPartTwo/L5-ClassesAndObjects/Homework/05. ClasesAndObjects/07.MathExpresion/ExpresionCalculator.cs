using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

public class ExpresionCalculator
{
    public static List<char> arithmeticOperations = new List<char> { '+', '-', '*', '/' };
    public static List<char> brackets = new List<char> { '(', ')' };
    public static List<string> functions = new List<string> { "ln", "pow", "sqrt" };

    //removes white spaces from input string
    public static string TrimInput(string input)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }

    //separates tokens from string in list
    public static List<string> SeparateTokens(string input)
    {
        List<string> result = new List<string>();
        var number = new StringBuilder();
        
       
        for (int i = 0; i < input.Length; i++)
        {
            //get numbers
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if(!char.IsDigit(input[i]) && input[i] != '.' && number.Length !=0)
            {
                result.Add(number.ToString());
                number.Clear();
                i--;
            }

            //get arithmetic
            else if (brackets.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (arithmeticOperations.Contains(input[i]) && number.Length == 0)
            {
                result.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                result.Add(",");
            }
            else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
            {
                result.Add("ln");
                i++;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
            {
                result.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid Expression");
            }
        }

        if (number.Length != 0)
        {
            result.Add(number.ToString());
        }


        return result;
    }

    //put the precedence of arithmetic operators
    public static int Precedence(string arithmeticOperator)
    {
        if (arithmeticOperator == "+" || arithmeticOperator == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
  
    //converts string from infix to postfix reverse polish notation
    public static Queue<string> ConvertToRPN(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double number;
            if (double.TryParse(currentToken, out number))
            {
                queue.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
                stack.Push (currentToken);
            }
            else if (currentToken == "," )
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets or function separator");
                }

                while (stack.Peek() != "(")
                {

                    //if not working > you might need to pop (
                    queue.Enqueue(stack.Pop());
                }
            }
                
            else if (arithmeticOperations.Contains(currentToken[0]))
            {
                //if not working refactor logic for current token
                while (stack.Count != 0 && arithmeticOperations.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
                stack.Push(currentToken);
            }

            else if(currentToken == "(")
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ")")
            {
                if(!stack.Contains("(") )
                {
                    throw new ArgumentException("Invalid brackets position");
                }
                while(stack.Peek() != "(" && stack.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();
                
                if ( stack.Count > 0 && functions.Contains(stack.Peek()) )
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }
        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid brackets");
            }
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }
   
    public static void PutInvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }

    public static double GetResultFromRPN(Queue<string> inputQueue)
    {
        Stack<double> stack = new Stack<double>();
        
        while (inputQueue.Count != 0)
        {
            double number;
            string currrentToken = inputQueue.Dequeue();
            if (double.TryParse(currrentToken, out number))
            {
                stack.Push(number);   
            }
            else if (functions.Contains(currrentToken) || arithmeticOperations.Contains(currrentToken[0]))
            {
                if (currrentToken == "+")
                {
                    if (stack.Count<2)
                    {
                        throw new ArgumentException("Invalid expression"); 
                    }
                    else
                    {
                        double first = stack.Pop();
                        double second = stack.Pop();
                        stack.Push(first + second);
                    }
                }
                else if (currrentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double first = stack.Pop();
                        double second = stack.Pop();
                        stack.Push(second - first);
                    }
                }
                else if (currrentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double first = stack.Pop();
                        double second = stack.Pop();
                        stack.Push(first * second);
                    }
                }
                else if (currrentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double first = stack.Pop();
                        double second = stack.Pop();
                        stack.Push(second / first);
                    }
                }
                else if (currrentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double first = stack.Pop();
                        double second = stack.Pop();
                        stack.Push(Math.Pow(second,first));
                    }
                }
                else if (currrentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double value = stack.Pop();
                        stack.Push(Math.Sqrt(value));
                    }
                }
                else if (currrentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression");
                    }
                    else
                    {
                        double value = stack.Pop();
                        stack.Push(Math.Log(value));
                    }
                }
            }
        }
        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArgumentException("Invalid expression");
        }
    }
    public static void Main(string[] args)
    {
        PutInvariantCulture();
        StartMethod();
        
       

        Console.WriteLine();
    }

    private static void StartMethod()
    {
        Console.WriteLine("Write expresion or 'end': ");
        string input = Console.ReadLine();
        while (input.ToLower() != "end")
        {
            try
            {
                //trim string
                string trimInput = TrimInput(input);

                //get tokens
                var separatedTokens = SeparateTokens(trimInput);

                //RPN
                var rpnTokens = ConvertToRPN(separatedTokens);
                Console.WriteLine("RPN of expression: ");
                Console.WriteLine(string.Join(" ", rpnTokens.ToArray()));

                Console.WriteLine("Result:");
                Console.WriteLine(GetResultFromRPN(rpnTokens));
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Write expresion or 'end': ");
            input = Console.ReadLine();
        }
    }
}
