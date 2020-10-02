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
                () => OR(ValueOne, ValueTwo),
                () => OrElse(ValueOne, ValueTwo),
                () => And(ValueOne, ValueTwo),
                () => AndAlso(ValueOne, ValueTwo),
                () => Xor(ValueOne, ValueTwo),
                () => Ternary(ValueOne, ValueTwo)
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

        public static string OR(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.Or(paramA, paramB);
            Func<T, T, T> orFunc = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} | {b} = {orFunc(a, b)}";
        }

        public static string OrElse(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.OrElse(paramA, paramB);
            Func<T, T, T> orElse = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} || {b} = {orElse(a, b)}";
        }
        public static string And(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.And(paramA, paramB);
            Func<T, T, T> And = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} & {b} = {And(a, b)}";
        }

        public static string AndAlso(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.AndAlso(paramA, paramB);
            Func<T, T, T> andAlso = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} && {b} = {andAlso(a, b)}";
        }

        public static string Xor(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.ExclusiveOr(paramA, paramB);
            Func<T, T, T> xor = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} ^ {b} = {xor(a, b)}";
        }

        /*public static string Xor(T a, T b)
        {
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");
            BinaryExpression body = Expression.ExclusiveOr(paramA, paramB);
            Func<T, T, T> xor = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return $"{a} ^ {b} = {xor(a, b)}";
        }*/

    }

}
