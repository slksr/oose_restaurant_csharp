using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public class SoccerPreparation : Preparation
    {
        private readonly bool useSimplePrep;

        public SoccerPreparation(bool useSimplePrep = true)
        {
            this.useSimplePrep = useSimplePrep;
        }
        public override void SetPreparationStep()
        {
            if (useSimplePrep)
            {
                PreparationSteps.Add(new PreparationStep(CommonPreparations.Apron));
            }
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Beer));
            PreparationSteps.Add(new PreparationStep(CommonPreparations.Anthem));
        }
    }
}
