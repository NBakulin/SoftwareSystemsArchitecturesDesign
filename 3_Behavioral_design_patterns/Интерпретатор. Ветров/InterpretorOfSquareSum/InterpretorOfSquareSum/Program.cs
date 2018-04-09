using System;
using System.Collections.Generic;

namespace InterpretorOfSquareSum
{
    class Context
    {
        Dictionary<string, int> variables;
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        public int GetVariable(string name)
        {
            return variables[name];
        }
        public void SetVariable(string name, int val)
        {
            if (variables.ContainsKey(name))
                variables[name] = val;
            else
                variables.Add(name, val);
        }
    }
    interface IExpression
    {
        int Interpret(Context context);
    }
    class NumberExpression : IExpression
    {
        string name;    //имя переменной
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
    class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
        public int Interpret(Context context)
        {
            return 
                leftExpression.Interpret(context) + 
                rightExpression.Interpret(context);
        }
    }
    class MultiplyExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
        public MultiplyExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
        public int Interpret(Context context)
        {
            return
                leftExpression.Interpret(context) *
                rightExpression.Interpret(context);
        }
    }
    class SquareExpression : IExpression
    {
        IExpression expression;
        public SquareExpression(IExpression exp)
        {
            expression = exp;
        }
        public int Interpret(Context context)
        {
            return
                expression.Interpret(context) * 
                expression.Interpret(context);
        }
    }

    class Program
    {
        
        //int a = 0;
        //int b = 0;
        static int InputValue(string str)
        {
            bool ok = false;
            int inp = 0;
            do
            {
                Console.Write(str + ": ");
                ok = Int32.TryParse(Console.ReadLine(), out inp);
            }
            while (!ok);
            return inp;
        }
        static IExpression SquareSum(Context context)
        {
            return new AddExpression(
                new AddExpression(
                    new SquareExpression(
                        new NumberExpression("a")),
                    new MultiplyExpression(
                        new MultiplyExpression(
                            new NumberExpression("2"), new NumberExpression("a")),
                        new NumberExpression("b")
                        )
                ), 
                new SquareExpression(new NumberExpression("b")));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление квадрата суммы первых двух чисел.");
            int a = InputValue("Введите первое число");
            int b = InputValue("Введите второе число");
            Context context = new Context();
            context.SetVariable("a", a);
            context.SetVariable("b", b);
            context.SetVariable("2", 2);
            IExpression expression = SquareSum(context);
            int result = expression.Interpret(context);
            Console.WriteLine("Результат: {0}", result);
            Console.Read();
        }
    }
}
