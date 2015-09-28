namespace ThirdReichTrainingCamp_FactoryMethod
{
    public class NavyTrainingCamp : TrainingCamp
    {

        public override Soldier Train()
        {
            return new KriegsMarine();
        }
    }
}