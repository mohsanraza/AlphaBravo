using System;

//Added here to do not import Aspose.Words dll for tests of adding/deleting throws clause functionality.

namespace Aspose
{
    /// <summary>
    /// Use this attribute to override whether CsPorter adds the "throws Exception" clause to a method or not.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class JavaThrowsAttribute : Attribute
    {
        public readonly bool IsThrows;

        public JavaThrowsAttribute(bool isThrows)
        {
            this.IsThrows = isThrows;
        }
    }
}