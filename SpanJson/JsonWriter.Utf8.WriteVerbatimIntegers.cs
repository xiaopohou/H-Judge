﻿// Autogenerated
// ReSharper disable BuiltInTypeReferenceStyle
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace SpanJson
{
    public ref partial struct JsonWriter<TSymbol> where TSymbol : struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(uint a)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 4)
            {
                Grow(4);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(uint a, byte b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 5)
            {
                Grow(5);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(uint a, ushort b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 6)
            {
                Grow(6);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(uint a, ushort b, byte c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 7)
            {
                Grow(7);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 8)
            {
                Grow(8);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, byte b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 9)
            {
                Grow(9);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ushort b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 10)
            {
                Grow(10);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ushort b, byte c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 11)
            {
                Grow(11);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, uint b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 12)
            {
                Grow(12);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, uint b, byte c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 13)
            {
                Grow(13);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, uint b, ushort c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 14)
            {
                Grow(14);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, uint b, ushort c, byte d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 15)
            {
                Grow(15);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 16)
            {
                Grow(16);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, byte c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 17)
            {
                Grow(17);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ushort c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 18)
            {
                Grow(18);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ushort c, byte d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 19)
            {
                Grow(19);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, uint c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 20)
            {
                Grow(20);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, uint c, byte d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 21)
            {
                Grow(21);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, uint c, ushort d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 22)
            {
                Grow(22);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, uint c, ushort d, byte e)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 23)
            {
                Grow(23);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), e);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 24)
            {
                Grow(24);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, byte d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 25)
            {
                Grow(25);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, ushort d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 26)
            {
                Grow(26);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, ushort d, byte e)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 27)
            {
                Grow(27);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), e);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, uint d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 28)
            {
                Grow(28);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, uint d, byte e)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 29)
            {
                Grow(29);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), e);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, uint d, ushort e)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 30)
            {
                Grow(30);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), e);
            pos += 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, uint d, ushort e, byte f)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 31)
            {
                Grow(31);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 4;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), e);
            pos += 2;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), f);
            pos += 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUtf8Verbatim(ulong a, ulong b, ulong c, ulong d)
        {
            ref var pos = ref _pos;
            if (pos > _bytes.Length - 32)
            {
                Grow(32);
            }

            ref var bStart = ref MemoryMarshal.GetReference(_bytes);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), a);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), b);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), c);
            pos += 8;
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref bStart, pos), d);
            pos += 8;
        }

    }
}