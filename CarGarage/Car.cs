using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }
        public void SetMake(string make)
        {
            Make = make;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public int GetSpeed()
        {
            return Speed;
        }
        public bool IsSpeeding()
        {
            if (Speed >= 71)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Accelerate()
        {
            if (Make == "Ferrari" && Speed <= 80)
            {
                Speed += 20;
            }
            else if (Speed <= 90)
            {
                Speed += 10;
            }
            else
            {
                Speed = 100;
            }
        }
        public void Brake()
        {
            if (AutoBrakeActive == true)
            {
                Speed = Speed /= 2;
            }
            else if (Speed >= 7)
            {
                Speed -= 7;
            }
            else if (Speed < 7 && Speed >= 0)
            {
                Speed = 0;
            }
        }
    }

}
