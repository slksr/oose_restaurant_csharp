using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public class HardRockPreparation : Preparation
    {
        public override void SetPreparationStep()
        {
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Knifes));
            PreparationSteps.Add(new PreparationStep(CommonPreparations.HardRock));            
        }
    }
}
