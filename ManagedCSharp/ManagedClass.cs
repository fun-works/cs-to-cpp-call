using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ManagedCSharp
{
    public static class ManagedClass
    {
        public static void ShowValue(ref int value)
        {
            Console.WriteLine("Test print");
            Console.ReadLine();
            return;
        }
    }
}
