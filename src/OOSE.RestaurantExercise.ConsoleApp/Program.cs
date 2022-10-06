using OOSE.RestaurantExercise.Logic;
using OOSE.RestaurantExercise.Logic.Preparations;

namespace OOSE.RestaurantExercise.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook cookCris = new Cook("Christian", PreparationFactory.GetPreparation(PreparationType.Simpel));
            Cook cookPeter = new Cook("Peter", PreparationFactory.GetPreparation(PreparationType.Hardrock));
            Cook cookMaria = new Cook("Maria", PreparationFactory.GetPreparation(PreparationType.Soccer));
            Cook cookRody = new Cook("Rody", PreparationFactory.GetPreparation(PreparationType.Soccer));

            Restaurant restaurant = new Restaurant(new List<Cook>() { cookCris, cookPeter, cookMaria, cookRody });
          
            restaurant.StartShift();
            
            restaurant.EndContractCooksWithPreparation(typeof(SoccerPreparation));
            Console.WriteLine($"Contract end for cooks with skill {typeof(SoccerPreparation).Name}. Number of cooks left {restaurant.Cooks.Count}" );
            Console.WriteLine(" ========== ");

            Console.WriteLine($"End contract for {cookPeter.Name}");
            restaurant.EndContractCook(cookPeter);
            Console.WriteLine(" ========== ");

            Cook cookMichel = new Cook("Michel", PreparationFactory.GetPreparation(PreparationType.Hardrock));
            restaurant.AddContractCook(cookMichel);
            restaurant.StartShift();
        }
    }
}