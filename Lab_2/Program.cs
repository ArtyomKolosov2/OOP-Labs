using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Data types in .Net and C#";
            List<IWrappedPrimitiveInfo> wrappedPrimitives = new List<IWrappedPrimitiveInfo>()
            {        
                new WrappedPrimitive<int>(10, 2),
                new WrappedPrimitive<double>(10d, 2d),
                new WrappedPrimitive<short>(10, 2),
                new WrappedPrimitive<char>('x', 'f'),
                new WrappedPrimitive<long>(10000, 432),
                new WrappedPrimitive<decimal>(343212.23424423m, 432324.23432m),
                new WrappedPrimitive<bool>(true, false),
                new WrappedPrimitive<float>(5.3f, 4f),
                new WrappedPrimitive<byte>(125, 5),
            };
            ShowTypeInfoService.ShowTypeCollectionInfo(wrappedPrimitives);
        }

        public static void Center(int amount, string msg, string symbol)
        {
            int divided_amount = amount / 2;
            for (int i = 0; i < amount; i++)
            {

                if (i == divided_amount)
                {
                    Console.Write(msg);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.Write("\n");
        }
    }

    //+-*/%| || & && ^ ? ?? !~~ = == != += -= *= /= %= => () <- -> ++ --  as instanceOf() GetType() typeof
    //byte short char int float double decimal bool long
    public static class ShowTypeInfoService
    {
        public static void ShowTypeInfo<T>(T type) where T : IWrappedPrimitiveInfo
        {
            type.ShowMainTypeInfo();
        }
        public static void ShowTypeCollectionInfo<T>(T typeCollection) where T : IEnumerable<IWrappedPrimitiveInfo>
        {
            foreach (var type in typeCollection)
            {
                ShowTypeInfo(type);
            }
        }
    }
}
