using System.Security.Cryptography.X509Certificates;

namespace _100Doors.Entities
{
    class Door
    {
        public Door(int doorNumber)
        {
            Open = false;
            DoorNumber = doorNumber;
        } 

        public bool Open { get; set; }
        public int DoorNumber { get; private set; }

        public bool ToggleOpen()
        {
            Open = !Open;
            return Open;
        }
    }
}
