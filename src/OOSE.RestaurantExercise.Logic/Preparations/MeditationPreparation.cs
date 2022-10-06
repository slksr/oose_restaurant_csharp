using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public class MeditationPreparation : Preparation
    {
        public override void SetPreparationStep()
        {
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Mindfull));
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Breath));
        }
    }
}
