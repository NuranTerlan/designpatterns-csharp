namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Car class inherits from Vehicle class, and it's a lower level abstraction in
    /// the bridge design pattern
    /// </summary>
    public class Car : Vehicle
    {
        public Car(Make make) : base(make)
        {
        }

        public override bool DrivingLicenseApproved(string driver) => driver == "has license";
    }
}