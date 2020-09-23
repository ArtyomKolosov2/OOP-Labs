using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{ 
    public class WrappedInt : IWrappedPrimitiveInfo, IValueHolder<int>
    {
        public int Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, MinValue = {int.MinValue}, MaxValue = {int.MaxValue}";
        }
    }

    public class WrappedByte : IWrappedPrimitiveInfo, IValueHolder<byte>
    {
        public byte Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, MinValue = {byte.MinValue}, MaxValue = {byte.MaxValue}";
        }
    }

    public class WrappedBool : IWrappedPrimitiveInfo, IValueHolder<bool>
    {
        public bool Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, MinValue = false, MaxValue = true";
        }
    }

    public class WrappedSbyte : IWrappedPrimitiveInfo, IValueHolder<sbyte>
    {
        public sbyte Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, MinValue = {sbyte.MinValue}, MaxValue = {sbyte.MaxValue}";
        }
    }

    public class WrappedShort : IWrappedPrimitiveInfo, IValueHolder<short>
    {
        public short Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, MinValue = {short.MinValue}, MaxValue = {short.MaxValue}";
        }
    }
}
