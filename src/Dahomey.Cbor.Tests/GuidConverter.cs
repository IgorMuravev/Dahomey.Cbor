﻿using Dahomey.Cbor.Serialization;
using Dahomey.Cbor.Serialization.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dahomey.Cbor.Tests
{
    public class GuidConverter : ICborConverter<Guid>
    {
        public Guid Read(ref CborReader reader)
        {
            ReadOnlySpan<byte> bytes = reader.ReadByteString();
            return new Guid(bytes);
        }

        public void Write(ref CborWriter writer, Guid value)
        {
            Span<byte> bytes = new byte[16];
            value.TryWriteBytes(bytes);
            writer.WriteByteString(bytes);
        }
    }
}
