
namespace DEV_1._3
{
    class Chassis
    {
        int _numberOfWheels;
        string _numberChassis;
        int _permissibleLoad;

        public Chassis(int numberOfWheels, string numberChassis, int permissibleLoad)
        {
            _numberOfWheels = numberOfWheels;
            _numberChassis = numberChassis;
            _permissibleLoad = permissibleLoad;
        }
        public virtual string GetInfo()
        {
            return $"Number of Wheels: {_numberOfWheels},  Number Of Classis {_numberChassis}, Permissible load {_permissibleLoad}";
        }
    }

}
