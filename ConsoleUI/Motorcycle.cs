using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle

    {

        bool hasSideCar { get; set; } = false;

        public override void DriveAbstract(Car car, Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        public override void DriveVirtual( Motorcycle motorcycle)
        {
            base.DriveVirtual(motorcycle);
        }
    }
}
