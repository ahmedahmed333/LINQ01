using static LINQ.DataSources.Source;
namespace linQ01

{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            var SeafoodCategory = ProductList.Where(p => p.Category == "Seafood");

            foreach (var category in SeafoodCategory)
            {
                Console.WriteLine($"{category.ProductName} - {category.UnitPrice}");
            }


     
            #endregion


        }
    }
}
