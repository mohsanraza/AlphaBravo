using CsPorter.Tests.Rename.Methods;

namespace CsPorter.TestFiles.Another.Namespace
{
#if TEST12


    class Test1_RenameMethods
    {
        void Goo()
        {
            mTest1.Foo(0);
            mTest1.Foo(0L);
            CsPorter.Tests.Rename.Methods.Test1.Clone();//full class name normalized to short name in java
        }

        void Doo(int i, long l)
        {
            mTest1.Foo(0);
            mTest1.Foo(0L);
            Goo();
            Test1.Clone();
        }

        Test1 mTest1 = new Test1();
    }
#endif
}