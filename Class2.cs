//23.11.09 by Konstantin Sidorenko

namespace TestProject.BadReferences
{
    public class Class2
    {
        void Method()
        {
            int i = CellMetrics.GetX(layout);
        }

        private CellLayout layout;
    }
}