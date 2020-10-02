using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Lab_2
{ 
    public class WrappedPrimitive<T> : IWrappedPrimitiveInfo where T : struct
    {

        public T ValueOne { get; set; } = default;
        public T ValueTwo { get; set; } = default;

        public WrappedPrimitive(T one, T two)
        {
            ValueOne = one;
            ValueTwo = two;
        }
        public WrappedPrimitive() { }
        public void ShowMainTypeInfo()
        {
            
            int amount = 50;
            string splitter = "=";
            Type type = typeof(T);
            Program.Center(amount, $"Type = {type.Name}", splitter);
            Func<string>[] actions = new Func<string>[]
            {
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "+", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 + c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "-", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 - c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "*", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 * c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "/", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 / c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "%", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 % c2)),
                () => GetStringBinaryOperator(ValueOne, ValueTwo, "&", new Func<dynamic, dynamic, dynamic>((c1, c2) => c1 & c2)),
                
            };
            foreach (var action in actions)
            {
                try
                {
                    Console.WriteLine(action?.Invoke());
                }
                catch (Exception ex)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = defaultColor;
                }
            }
            //?? !~~ = == != += -= *= /= %= => () < - -> ++-- as instanceOf() GetType() typeof


        }
        public static string Ternary(dynamic c1, dynamic c2)
        {
            return $"c1 > c2 ? true : false = {(c1>c2?true:false)}";
        }

        public static string GetStringBinaryOperator(dynamic c1, dynamic c2, string opStrRepr, Func<dynamic, dynamic, dynamic> func)
        {
            return $"{c1} {opStrRepr} {c2} = {func?.Invoke(c1, c2)}";
        }
    }

}
