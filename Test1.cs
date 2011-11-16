//24.05.10 by Konstantin Sidorenko

using System;
using System.IO;

namespace CsPorter.Tests.Change.AddThrows.Ctors
{
    public class Test1
    {
        //empty ctor should not throw.
        Test1()
        {}

        //ctor without external calls - should not throw too.
        Test1(int i)
        {
            mInt = i;
        }

        //shouldn't throw
        Test1(double d)
        {
            mDouble = Math.PI * d;
        }

        //should throw
        Test1(byte b)
        {
            mStream = new FileStream(b.ToString(), FileMode.Truncate);
        }

        //should throw
        Test1(short sh)
        {
            mInt = mStream.ReadByte();
        }

        //should throw
        Test1(Stream stream)
        {
            mInt = (int) stream.Position;
        }

        private Stream mStream;
        private int mInt;
        private double mDouble;
    }
}