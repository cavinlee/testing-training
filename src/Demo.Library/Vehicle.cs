using System;

namespace Demo.Library
{
    public class VehicleException : Exception
    {

    }

    public class Vehicle
    {
        public Vehicle(string plateNo)
        {
            PlateNo = plateNo;
        }

        public string PlateNo { get; set; }
        public bool IsOpened { get; set; }
        public bool IsByPassed { get; set; }

        public void Open()
        {
            IsOpened = true;
        }

        public void Close()
        {
            IsOpened = false;
        }

        public void Move()
        {
            if (IsByPassed)
            {
                return;
            }

            if (IsOpened)
            {
                throw new VehicleException();
            }
        }

        public void BypassSecurity()
        {
            IsByPassed = true;
        }
    }
}
