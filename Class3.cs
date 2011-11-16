//23.11.09 by Konstantin Sidorenko

using Aspose.Layout.Core.CellMetrics;

namespace TestProject.BadReferences
{
    public class Class3
    {
        void Method(CellMetrics metrics)
        {
            StaticMethod(metrics);
        }

        void Method2()
        {
            StaticMethod(BorderType.Left);
        }

        internal static void StaticMethod(CellMetrics metrics)
        {}
    }
}