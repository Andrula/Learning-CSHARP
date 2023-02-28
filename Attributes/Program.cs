using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
        public class TestAttribute : Attribute
        {

        }

        [TestAttribute]
        public class Test
        {
            [TestAttribute]
            int testProperty { get; set; }
            [TestAttribute]
            public void testMethod()
            {

            }
        }
    }
}
