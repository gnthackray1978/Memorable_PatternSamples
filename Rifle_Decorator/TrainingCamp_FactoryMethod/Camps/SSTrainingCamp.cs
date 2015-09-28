namespace ThirdReichTrainingCamp_FactoryMethod
{
    public class SSTrainingCamp : TrainingCamp
    {

        public override Soldier Train()
        {
            return new SSTrooper();
        }
    }
}