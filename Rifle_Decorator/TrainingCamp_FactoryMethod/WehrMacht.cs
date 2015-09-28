namespace ThirdReichTrainingCamp_FactoryMethod
{
    public class WehrMacht : Soldier
    {
        private readonly bool _isArmy;
        public WehrMacht()
        {
            _isArmy = true;
        }

        public bool IsArmy
        {
            get { return _isArmy; }
        }
    }
}