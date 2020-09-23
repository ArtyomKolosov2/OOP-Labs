using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWrappedPrimitiveInfo> wrappedPrimitives = new List<IWrappedPrimitiveInfo>()
            {
                new WrappedInt(),
                new WrappedByte(),
                new WrappedBool(),
                new WrappedSbyte(),
                new WrappedShort(),
                new WrappedChar(),
                new WrappedFloat(),
                new WrappedDouble(),
                new WrappedDecimal(),
                new WrappedUint(),
                new WrappedUlong(),
                new WrappedUshort(),
                new WrappedObject(),
                new WrappedString(),
                new WrappedLong(),
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
