using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27FebConsoleApp
{
    public class Access_Specifier
    {
        private int privatedata;  // private by default
        public int publicdata;
        internal int internaldata;
        protected int protecteddata;

        internal protected int intprocdata;
        
        public void testprivate()
        {
            privatedata = 6;
        }
    }

    class Driver : Access_Specifier
    {
        public void TestingAccess()
        {
            Access_Specifier ase = new Access_Specifier();
            ase.publicdata = 5;
            ase.testprivate();
            ase.internaldata = 20;
            ase.intprocdata = 30;

            Driver d = new Driver();
            d.publicdata = 1;
            d.internaldata = 2;
            d.protecteddata = 3;
            d.intprocdata = 4;
        }
    }

    class Test
    {
        public void tester()
        {
            Access_Specifier a1 = new Access_Specifier();
            a1.internaldata = 11;
            a1.intprocdata = 12;
        }
    }
}
