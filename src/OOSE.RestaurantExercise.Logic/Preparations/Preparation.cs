using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public abstract class Preparation
    {
        private readonly List<PreparationStep> preparationSteps;

        protected Preparation()
        {
            preparationSteps = new List<PreparationStep>();
        }

        public List<PreparationStep> PreparationSteps
        {
            get => preparationSteps;
        }

        public abstract void SetPreparationStep();

    }
}
