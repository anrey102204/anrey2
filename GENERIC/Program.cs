using System;
using System.Text;
using System.Threading.Tasks;
using static GENERIC.Program;

namespace GENERIC
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            choices crdtest = new choices();
            crdtest.testing();

        }
        public static void Option()
        {
            Console.WriteLine("\n_____OPTION_____");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Read Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
        }
        public static void test()
        {
            Console.WriteLine("_____CLICK 1 TO TEST_____");
            Console.WriteLine("1. Repository <Student> ");
            Console.WriteLine("2. DictionaryRepository<int, Product> ");
        }
        public static void Option2()
        {
            Console.WriteLine("\n_____OPTION_____\n");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Read Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
        }
    }


}
