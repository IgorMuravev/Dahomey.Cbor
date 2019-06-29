﻿namespace Dahomey.Cbor.Serialization.Converters
{
    public class UInt64Converter : ICborConverter<ulong>
    {
        public ulong Read(ref CborReader reader)
        {
            return reader.ReadUInt64();
        }

        public void Write(ref CborWriter writer, ulong value)
        {
            writer.WriteUInt64(value);
        }
    }
}
