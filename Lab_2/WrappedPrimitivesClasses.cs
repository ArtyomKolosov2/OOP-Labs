using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{ 
    public class WrappedInt : IWrappedPrimitiveInfo, IValueHolder<int>
    {
        public int Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            var fields = Value.GetType().GetFields();
            var x = fields.FirstOrDefault(x => x.Name == "MinValue");
            
            return $"Type = {Value.GetType()}, Size = 4 bytes | MinValue = {int.MinValue}, MaxValue = {int.MaxValue}";
        }
    }

    public class WrappedByte : IWrappedPrimitiveInfo, IValueHolder<byte>
    {
        public byte Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 1 bytes | MinValue = {byte.MinValue}, MaxValue = {byte.MaxValue}";
        }
    }

    public class WrappedBool : IWrappedPrimitiveInfo, IValueHolder<bool>
    {
        public bool Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 1 bytes | MinValue = false, MaxValue = true";
        }
    }

    public class WrappedSbyte : IWrappedPrimitiveInfo, IValueHolder<sbyte>
    {
        public sbyte Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 1 bytes | MinValue = {sbyte.MinValue}, MaxValue = {sbyte.MaxValue}";
        }
    }

    public class WrappedShort : IWrappedPrimitiveInfo, IValueHolder<short>
    {
        public short Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 2 bytes | MinValue = {short.MinValue}, MaxValue = {short.MaxValue}";
        }
    }

    public class WrappedUshort : IWrappedPrimitiveInfo, IValueHolder<ushort>
    {
        public ushort Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 2 bytes | MinValue = {ushort.MinValue}, MaxValue = {ushort.MaxValue}";
        }
    }
    public class WrappedUint : IWrappedPrimitiveInfo, IValueHolder<uint>
    {
        public uint Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 4 bytes | MinValue = {uint.MinValue}, MaxValue = {uint.MaxValue}";
        }
    }
    public class WrappedLong : IWrappedPrimitiveInfo, IValueHolder<long>
    {
        public long Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 8 bytes | MinValue = {long.MinValue}, MaxValue = {long.MaxValue}";
        }
    }

    public class WrappedUlong : IWrappedPrimitiveInfo, IValueHolder<ulong>
    {
        public ulong Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 8 bytes | MinValue = {ulong.MinValue}, MaxValue = {ulong.MaxValue}";
        }
    }

    public class WrappedFloat : IWrappedPrimitiveInfo, IValueHolder<float>
    {
        public float Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 4 bytes | MinValue = {float.MinValue}, MaxValue = {float.MaxValue}\n";
        }
    }

    public class WrappedDouble : IWrappedPrimitiveInfo, IValueHolder<double>
    {
        public double Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 8 bytes | MinValue = {double.MinValue}, MaxValue = {double.MaxValue}";
        }
    }

    public class WrappedDecimal : IWrappedPrimitiveInfo, IValueHolder<decimal>
    {
        public decimal Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 16 bytes | MinValue = {decimal.MinValue}, MaxValue = {decimal.MaxValue}";
        }
    }

    public class WrappedChar : IWrappedPrimitiveInfo, IValueHolder<char>
    {
        public char Value { get; set; } = default;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = 2 bytes | MinValue = {(int)char.MinValue}, MaxValue = {(int)char.MaxValue}";
        }
    }

    public class WrappedString : IWrappedPrimitiveInfo, IValueHolder<string>
    {
        public string Value { get; set; } = string.Empty;

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = N/A";
        }
    }

    public class WrappedObject : IWrappedPrimitiveInfo, IValueHolder<object>
    {
        public object Value { get; set; } = new object();

        public string GetMainTypeInfo()
        {
            return $"Type = {Value.GetType()}, Size = N/A";
        }
    }

    
}
