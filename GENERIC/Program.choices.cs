using System;

namespace GENERIC
{

    internal partial class Program
    {
        public class choices
        {
            public int choose;
            crud crd = new crud();
            crud2 crd2 = new crud2();
            public void testing()
            {
                Program.test();
                Console.Write("Choose to Test:");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("\n_STUDENT REPOSITORY MANAGEMENT_");
                        crd.Introduce();
                        break;
                    case 2:
                        Console.WriteLine("\n_PRODUCT REPOSITORY MANAGEMENT_");
                        crd2.SecondIntroduce();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

        }
    }


}
