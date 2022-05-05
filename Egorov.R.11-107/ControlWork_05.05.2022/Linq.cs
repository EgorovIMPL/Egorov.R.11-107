using System;
using System.Collections.Generic;
using System.Linq;

namespace Egorov.R._11_107.ControlWork_05._05._2022
{
    /// <summary>
    /// просто на 3 балла, сложный на 5 баллов
    /// </summary>
    public class Linq
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Price
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public decimal Sum { get; set; }
            public bool IsActual { get; set; }
        }

        public class Check
        {
            public List<Product> Product { get; set; }
            public List<Price> Price { get; set; }
            public List<int> NumberOfProduct { get; set; }
        }

        private List<Check> checkList;

        public void Run()
        {
            var products = new List<Product>
            {
                new Product {Id = 1, Name = "Аквариум 10 литров"},
                new Product {Id = 2, Name = "Аквариум 20 литров"},
                new Product {Id = 3, Name = "Аквариум 50 литров"},
                new Product {Id = 4, Name = "Аквариум 100 литров"},
                new Product {Id = 5, Name = "Аквариум 200 литров"},
                new Product {Id = 6, Name = "Фильтр"},
                new Product {Id = 7, Name = "Термометр"}
            };

            var prices = new List<Price>
            {
                new Price {Id = 1, ProductId = 1, Sum = 100, IsActual = false},
                new Price {Id = 2, ProductId = 1, Sum = 123, IsActual = true},
                new Price {Id = 3, ProductId = 2, Sum = 234, IsActual = true},
                new Price {Id = 4, ProductId = 3, Sum = 532, IsActual = true},
                new Price {Id = 5, ProductId = 4, Sum = 234, IsActual = true},
                new Price {Id = 6, ProductId = 5, Sum = 534, IsActual = true},
                new Price {Id = 7, ProductId = 5, Sum = 124, IsActual = false},
                new Price {Id = 8, ProductId = 6, Sum = 153, IsActual = true},
                new Price {Id = 9, ProductId = 7, Sum = 157, IsActual = true}
            };
            /*Задания              * 
             * 1) создать список счетов (один счет содержит несколько пар цена-количество)
             * например, один счет - это аквариум на 200 литров, два фильтра и термометр
             * 2) вывести счет для покупателя с колонками "Наименование услуги, сумма, итого"
             *  - 1 балл
             * 3) Вывести среднюю цену для каждого продукта с учетом неактуальных значений
             * - 1 балл
             * 4) создать список акций (код продукта, скидка):
             * аквариум на 200 литров + 2 фильтра - скидка 15%
             * аквариум 100 литров + 2 фильтра - 10% скидка
             * любой другой аквариум + фильтр - 5% скидка
             * 5) создать список перенчень всех названий товаров в группе акции + 
             * цена до скидки + цена с учетом скидки  - 1 балл
             * 
             * Для тех, кто выбрал вариант посложнее: написать функцию подсчета 
             * суммы покупки (выявлять, есть ли в наборе продуктов акционные комплекты,
             * при их наличии делать скидку) - это + 2 балла
             */
        }

        /// <summary>
        /// prices - база данных цен
        /// </summary>
        /// <param name="products"></param>
        /// <param name="prices"></param> 
        /// <param name="numbers"></param>
        public void AddCheck(List<Product> products, List<Price> prices, List<int> numbers)
        {
            List<Price> checkPrices = new List<Price>();
            foreach (var product in products)
            foreach (var price in prices)
                if (product.Id == price.ProductId && price.IsActual == true)
                {
                    checkPrices.Add(price);
                    break;
                }

            checkList.Add(new Check() {NumberOfProduct = numbers, Price = checkPrices, Product = products});
        }

        public void PrintCheck()
        {
            int sum = 0;
            Console.WriteLine("Наименование услуги, сумма, итого:");
            foreach (var check in checkList)
            {
                for (int i = 0; i < check.Product.Count; i++)
                {
                    sum += Convert.ToInt32(check.Price[i].Sum * check.NumberOfProduct[i]);
                    Console.WriteLine(check.Product[i].Name + check.Price[i].Sum + sum);
                }
            }
        }

        public List<decimal> AverageSum(List<Price> prices)
        {
            return prices.GroupBy(price => price.ProductId)
                .Select(x => x.Average(y => y.Sum))
                .ToList();
        }
    }
}