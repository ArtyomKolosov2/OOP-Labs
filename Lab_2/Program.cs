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
                new WrappedBool(),
                new WrappedSbyte(),
                new WrappedByte(),
                new WrappedChar(),
                new WrappedUshort(),
                new WrappedShort(),
                new WrappedInt(),
                new WrappedUint(),
                new WrappedUlong(),
                new WrappedLong(),
                new WrappedFloat(),
                new WrappedDouble(),
                new WrappedDecimal(),
                new WrappedObject(),
                new WrappedString(),
                
            };
            ShowTypeInfoService.ShowTypeCollectionInfo(wrappedPrimitives);
        }
    }
    public static class ShowTypeInfoService
    {
        public static void ShowTypeInfo<T>(T type) where T : IWrappedPrimitiveInfo
        {
            Console.WriteLine(type.GetMainTypeInfo());
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
