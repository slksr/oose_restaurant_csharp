using OOSE.RestaurantExercise.Logic;

namespace OOSE.RestaurantExercise.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simplePrep = new Preparation();
            simplePrep.SetPreparationStep(new PreparationStep(CommonPreparations.Apron));

            var hardrockPrep = new Preparation();
            hardrockPrep.SetPreparationStep(new PreparationStep(CommonPreparations.Apron));
            hardrockPrep.SetPreparationStep(new PreparationStep(CommonPreparations.Knifes));
            hardrockPrep.SetPreparationStep(new PreparationStep(CommonPreparations.HardRock));

            var soccerPrep = new Preparation();
            soccerPrep.SetPreparationStep(new PreparationStep(CommonPreparations.Beer));
            soccerPrep.SetPreparationStep(new PreparationStep(CommonPreparations.Anthem));

            Cook cookCris = new Cook("Christian", simplePrep);
            Cook cookPeter = new Cook("Peter", hardrockPrep);
            Cook cookMaria = new Cook("Maria", soccerPrep);
            Cook cookRody = new Cook("Rody", soccerPrep);


            Restaurant restaurant = new Restaurant(new List<Cook>() { cookCris, cookPeter, cookMaria, cookRody });
            restaurant.StartShift();
        }
    }
}