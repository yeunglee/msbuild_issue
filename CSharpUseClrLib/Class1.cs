using System;
using ClrLib;

namespace CSharpUseClrLib
{
    public class Class1
    {
        static string Method() => typeof(Class1).FullName;
    }
}
