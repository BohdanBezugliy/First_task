using System.Data;

namespace First_task
{
    internal class Program
    {
        struct Product
        {
            public string NameSalesperson { get; set; }
            public string Name { get; set; }
            public int Count { get; set; }
            public int Price { get; set; }
            public byte DataSaleDay { get; set; }
            public byte DataSaleMonth { get; set; }
            public uint DataSaleYear { get; set; }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.Write("Введіть кількість продуктів: ");
            int countProduct=int.Parse(Console.ReadLine());
            Product[] products = new Product[countProduct];
            List<int> listProd = new List<int>();
            Console.WriteLine("Введіть відомості про товар в такій послідовності: продавець, назва, кількість, ціна, дата продажу(день, місяць, рік)");
            for (int i = 0; i < countProduct; i++)
            {
                Console.WriteLine($"Товар №{i+1}");
                products[i].NameSalesperson = Console.ReadLine();
                products[i].Name = Console.ReadLine();
                products[i].Count= int.Parse(Console.ReadLine());
                products[i].Price = int.Parse(Console.ReadLine());
                products[i].DataSaleDay=byte.Parse(Console.ReadLine());
                products[i].DataSaleMonth = byte.Parse(Console.ReadLine());
                products[i].DataSaleYear= uint.Parse(Console.ReadLine());
                if (products[i].DataSaleYear == DateTime.Now.Year)
                    listProd.Add(i);
            }
            Console.WriteLine($"Кількість товарів {listProd.Count} яка була продана менше року тому та їх відомості:");
            foreach(int i in listProd)
            {
                Console.WriteLine($"Продавець: {products[i].NameSalesperson}");
                Console.WriteLine($"Назва: {products[i].Name}");
                Console.WriteLine($"Кількість: {products[i].Count}");
                Console.WriteLine($"Ціна: {products[i].Price}");
                if(products[i].DataSaleDay>10 && products[i].DataSaleMonth > 10)
                    Console.WriteLine($"Дата продажу: {products[i].DataSaleDay}.{products[i].DataSaleMonth}.{products[i].DataSaleYear}");
                else if (products[i].DataSaleDay > 10 && products[i].DataSaleMonth < 10)
                    Console.WriteLine($"Дата продажу: {products[i].DataSaleDay}.0{products[i].DataSaleMonth}.{products[i].DataSaleYear}");
                else
                    Console.WriteLine($"Дата продажу: 0{products[i].DataSaleDay}.{products[i].DataSaleMonth}.{products[i].DataSaleYear}");
            }
        }
    }
}