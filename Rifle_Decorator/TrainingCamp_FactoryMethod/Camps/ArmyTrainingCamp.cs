namespace ThirdReichTrainingCamp_FactoryMethod
{
    public class ArmyTrainingCamp : TrainingCamp
    {

        public override Soldier Train()
        {
            return new WehrMacht();
        }
    }
}