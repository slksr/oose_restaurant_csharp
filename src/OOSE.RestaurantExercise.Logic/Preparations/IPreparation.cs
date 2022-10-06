namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public interface IPreparation
    {
        List<PreparationStep> PreparationSteps { get; }

        void SetPreparationStep();
    }
}