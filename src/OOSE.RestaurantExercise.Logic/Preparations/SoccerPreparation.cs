using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public class SoccerPreparation : IPreparation
    {
        private readonly bool useSimplePrep;

        public SoccerPreparation(bool useSimplePrep = true)
        {
            PreparationSteps = new List<PreparationStep>(); 
            this.useSimplePrep = useSimplePrep;
        }

        public List<PreparationStep> PreparationSteps { get; }

        public void SetPreparationStep()
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
