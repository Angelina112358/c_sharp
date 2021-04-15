using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll;

namespace forDll
{
    class Class1
    {
        static public void Main(String []args)
        {
            char contin = ' ';
            while (contin!='N')
            {
                Console.Clear();
                Dll.Tetrahedron.Volume();
                Console.WriteLine("Если хотите выйти, нажмите \"N\"." +
                    "Если хотите продолжить, нажмите любую клавишу.");
                contin = Console.ReadKey().KeyChar;
            }
        }
    }
}
