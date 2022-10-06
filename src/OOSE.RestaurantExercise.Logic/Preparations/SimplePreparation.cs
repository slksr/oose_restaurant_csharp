using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public class SimplePreparation : IPreparation
    {
        public SimplePreparation()
        {
            PreparationSteps = new List<PreparationStep>();
        }
        public List<PreparationStep> PreparationSteps { get; }

        public void SetPreparationStep()
        {
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Apron));
        }
    }
}
