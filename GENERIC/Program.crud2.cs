using System;

namespace GENERIC
{

    internal partial class Program
    {
        public class crud2
        {

            DictionaryRepository<int, Product> dictionaryRepository = new DictionaryRepository<int, Product>();
            public int productid, Choice2;
            public string productname;

            public void SecondIntroduce()
            {
                while (true)
                {
                    Program.Option2();
                    Console.Write("Enter your Choice in Option: ");
                    Choice2 = int.Parse(Console.ReadLine());

                    switch (Choice2)
                    {
                        case 1:
                            ADDPRODUCT();
                            break;
                        case 2:
                            READPRODUCT();
                            break;
                        case 3:
                            UPDATEPRODUCT();
                            break;
                        case 4:
                            DELETEPRODUCT();
                            break;
                        case 5:
                            EXIT2();
                            return;
                        default:
                            break;
                    }

                }

            }
            public void ADDPRODUCT()
            {
                Console.WriteLine("\n_____ADD PRODUCT_____");
                Console.Write("Enter Product ID: ");
                productid = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                productname = Console.ReadLine();
                if (!dictionaryRepository.ContainsKey(productid))
                {
                    dictionaryRepository.Add(productid, new Product { ProductName = productname });
                    Console.WriteLine("Product Successfully Added");
                }
                else
                {
                    Console.WriteLine("ID already Exist!!!");
                }
            }
            public void READPRODUCT()
            {
                Console.WriteLine("\n_____RETRIEVE PRODUCT_____");
                Console.Write("Enter Product ID to Retrieve: ");
                productid = int.Parse(Console.ReadLine());


                if (dictionaryRepository.ContainsKey(productid))
                {
                    var product = dictionaryRepository.Get(productid);
                    Console.WriteLine("\tProductID \tProductName");
                    Console.WriteLine($"Product: {productid} \t\t{product.ProductName}");
                }
                else
                {
                    Console.WriteLine("Product ID not Found!!!");

                }

            }
            public void UPDATEPRODUCT()
            {
                Console.WriteLine("\n_____UPDATE PRODUCT_____");
                Console.Write("Enter ID to Update: ");
                productid = int.Parse(Console.ReadLine());
                if (dictionaryRepository.ContainsKey(productid))
                {
                    var product = dictionaryRepository.Get(productid);
                    Console.Write("Enter new Product Name: ");
                    productname = Console.ReadLine();
                    if (!string.IsNullOrEmpty(productname)) product.ProductName = productname;
                    dictionaryRepository.Update(productid, product);
                }
                else
                {
                    Console.WriteLine("Product ID not Found!!!");
                }

            }
            public void DELETEPRODUCT()
            {
                Console.WriteLine("\n_____DELETE PRODUCT_____");
                Console.Write("Enter ID to DELETE: ");
                productid = int.Parse(Console.ReadLine());


                if (dictionaryRepository.ContainsKey(productid))
                {
                    var product = dictionaryRepository.Get(productid);
                    dictionaryRepository.Delete(productid);
                    Console.WriteLine("Product Deleted Successfully!!!");
                }
                else
                {
                    Console.WriteLine("Product ID not Found!!!");
                }

            }
            public void EXIT2()
            {
                Console.WriteLine("_EXIT_");
            }

        }
    }


}
