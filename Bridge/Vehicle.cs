namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Vehicle class is a top level abstraction in the bridge design pattern
    /// </summary>
    public abstract class Vehicle
    {
        private Make _make;

        protected Vehicle(Make make)
        {
            _make = make;
        }

        public abstract bool DrivingLicenseApproved(string driver);

        public void Power()
        {
            _make.PerformRitual();
            _make.StartEngine();
        }
    }
}