using System.Text;

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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Name} is preparing: "); 
            foreach (var preparationStep in Preparation.PreparationSteps) 
            {
                stringBuilder.AppendLine(preparationStep.Step);
            }
            return stringBuilder.ToString();
        }

    }
}