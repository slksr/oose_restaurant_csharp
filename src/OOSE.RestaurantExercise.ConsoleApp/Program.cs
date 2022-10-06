using OOSE.RestaurantExercise.Logic;
using OOSE.RestaurantExercise.Logic.Preparations;

namespace OOSE.RestaurantExercise.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook cookCris = new Cook("Christian", new SimplePreparation());
            Cook cookPeter = new Cook("Peter", new HardRockPreparation());
            Cook cookMaria = new Cook("Maria", new SoccerPreparation(false));
            Cook cookRody = new Cook("Rody", new SoccerPreparation());

            Restaurant restaurant = new Restaurant(new List<Cook>() { cookCris, cookPeter, cookMaria, cookRody });
          
            restaurant.StartShift();
            
            restaurant.EndContractCooksWithPreparation(typeof(SoccerPreparation));
            Console.WriteLine($"Contract end for cooks with skill {typeof(SoccerPreparation).Name}. Number of cooks left {restaurant.Cooks.Count}" );
        }
    }
}