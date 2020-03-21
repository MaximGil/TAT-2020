
namespace DEV_1._3
{
    class Transmission
    {
        string _typeOfTransmission;
        int _numberOfGears;
        string _manufacturer;

        public Transmission(string typeOfTransmission, int numberOfGears, string manufacturer)
        {
            _typeOfTransmission = typeOfTransmission;
            _numberOfGears = numberOfGears;
            _manufacturer = manufacturer;
        }
        public virtual string GetInfo()
        {
            return $"Type of transmission {_typeOfTransmission}, Number of gears: {_numberOfGears}, Manufacter: {_manufacturer}";
        }
    }
}
