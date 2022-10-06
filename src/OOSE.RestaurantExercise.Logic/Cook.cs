using System.Text;
using OOSE.RestaurantExercise.Logic.Preparations;

namespace OOSE.RestaurantExercise.Logic
{
    public class Cook
    {
        public Cook(string name, Preparation preparation)
        {
            Name = name;
            Preparation = preparation;
        }

        public Preparation Preparation;
        public string Name { get; }

        public string StartPreparation()
        {
            Preparation.SetPreparationStep();
            return Prepare();
        }

        private string Prepare()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Name} is preparing ({Preparation.GetType().Name}): ");
            foreach (var preparationStep in Preparation.PreparationSteps)
            {
                stringBuilder.AppendLine(preparationStep.Step);
            }
            return stringBuilder.ToString();
        }
    }
}