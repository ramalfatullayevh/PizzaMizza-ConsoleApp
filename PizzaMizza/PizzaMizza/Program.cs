using PizzaMizza.Contexts;
using PizzaMizza.Moduls;
using PizzaMizza.Service;

namespace PizzaMizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PizzaService pizzaService = new PizzaService();
            //Pizza pizza = new Pizza { Name = "Çiken Strips", Image = "https://pizzamizza.az/upload/iblock/6f5/6f5d4cdf454946331725eae7b571a6e9.jpg?1617617212113510" };
            //pizzaService.Add(pizza);

            //pizzaService.Delete(3);

            //foreach (var item in pizzaService.GetAll())
            //{
            //    Console.WriteLine($" {item.Name}, {item.Image}");
            //}

            Context context = new Context();
            //context.Ingredient.Add(new Ingredient { Name = "Holland Pendiri" });

            //context.Ingredient.Delete(3);

            //foreach (var item in context.Ingredient.GetAll())
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //context.Ingredient.Update(new Ingredient {Name = "Chili Biber" , Id = 6 });


            //-----------------------------------------------------------

            //context.Size.Add(new Size { SizeName = "Big" });

            //context.Size.Delete(2);

            //foreach (var item in context.Size.GetAll())
            //{
            //    Console.WriteLine($"{item.SizeName}");
            //}

            //context.Size.Update(new Size { SizeName = "XLarge", Id = 3 });

            //-----------------------------------------------------------





        }
    }
}