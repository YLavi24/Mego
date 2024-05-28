using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Bus
    {
        string name, plateNumber, routeNumber;
        int passengers;
        public Bus(string name, string plateNumber, string routeNumber, int passengers)
        {
            this.name = name;
            this.plateNumber = plateNumber;
            this.routeNumber = routeNumber;
            this.passengers = passengers;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetplateNumber(string plateNumber)
        {
            this.plateNumber = plateNumber;
        }
        public void SetrouteNumber(string routeNumber)
        {
            this.routeNumber = routeNumber;
        }
        public void SetPassengers(int passengers)
        {
            this.passengers = passengers;
        }
        public string GetName()
        {
            return name;
        }
        public string GetplateNumber()
        {
            return plateNumber;
        }
        public string GetrouteNumber()
        {
            return routeNumber;
        }
        public int GetPassengers()
        {
            return passengers;
        }
        public override string ToString()
        {
            return $"{name} : {plateNumber} : {routeNumber} : {passengers}";
        }

    }

}
