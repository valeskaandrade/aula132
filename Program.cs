using System;
using System.Globalization;
using System.Collections.Generic;
using Aula132Produto.Entities;

namespace Aula132Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de N
            produtos(N fornecido pelo usuário).Ao final,
            mostrar a etiqueta de preço de cada produto na
            mesma ordem em que foram digitados.
            Todo produto possui nome e preço. Produtos
            importados possuem uma taxa de alfândega, e
            produtos usados possuem data de fabricação.
            Estes dados específicos devem ser
            acrescentados na etiqueta de preço conforme
            exemplo(próxima página).Para produtos
            importados, a taxa e alfândega deve ser
            acrescentada ao preço final do produto.*/
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> lista = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c/ u / i)? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'u')
                {
                    Console.Write("Manufacture date(DD / MM / YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    lista.Add(new UsedProduct(name, price, manufactureDate));

                }
                else if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(name, price, customsFee));

                }
                else
                {
                    lista.Add(new Product(name, price));
                }

            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product P in lista)
            {
                Console.WriteLine(P.PriceTag());
            }

        }
    }
}
