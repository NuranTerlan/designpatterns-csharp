namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Bus class inherits from Vehicle class, and it's a lower level abstraction in
    /// the bridge design pattern
    /// </summary>
    public class Bus : Vehicle
    {
        public Bus(Make make) : base(make)
        {
        }

        public override bool DrivingLicenseApproved(string driver) =>
            driver == "has special bus license";
    }
}