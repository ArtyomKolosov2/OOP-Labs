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
                () => Add(ValueOne, ValueTwo),
                () => Divide(ValueOne, ValueTwo),
                () => Multiply(ValueOne, ValueTwo),
                () => Minus(ValueOne, ValueTwo),
                () => DivMod(ValueOne, ValueTwo),
            };
            foreach (var action in actions)
            {
                try
                {
                    Console.WriteLine(action?.Invoke());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
        public static string Add(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Add(paramA, paramB);
            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} + {b} = {add(a,b)}";
        }

        public static string Divide(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Divide(paramA, paramB);
            Func<T, T, T> divide = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} / {b} = {divide(a, b)}";
        }

        public static string Multiply(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Multiply(paramA, paramB);
            Func<T, T, T> multi = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} * {b} = {multi(a, b)}";
        }

        public static string Minus(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Subtract(paramA, paramB);
            Func<T, T, T> minus = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} - {b} = {minus(a, b)}";
        }

        public static string DivMod(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Modulo(paramA, paramB);
            Func<T, T, T> divMod = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} % {b} = {divMod(a, b)}";
        }

    }

}
