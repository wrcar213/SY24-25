using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class CarCard
    {
        public enum category { maxspeed, zerotosixty, HP, CC, Cylinders, RPM, ID}
        public string name {  get; set; }
       public int maxspeed {  get; set; }
        public double zerotosixty { get; set; }
        public int HP { get; set; }
        public int CC { get; set; }
        public int Cylinders { get; set; }
        public int RPM { get; set; }
        public string ID { get; set; }

        public CarCard(String name, int maxspeed, double zerotosixty, int HP, int CC, int Cylinders, int RPM, string ID)
        {
            
            this.name = name;
            this.maxspeed = maxspeed;
            this.zerotosixty = zerotosixty;
            this.HP = HP;
            this.CC = CC;
            this.Cylinders = Cylinders;
            this.RPM = RPM;
            this.ID = ID;

        }
        public CarCard Compare(CarCard other, category c)
        {
            if (other == null) return this;
            if (c == category.maxspeed)
                if (maxspeed > other.maxspeed)
                    return this;
                else
                    return other;

            if (other == null) return this;
            if (c == category.zerotosixty) 
                if (zerotosixty < other.zerotosixty)
                    return this;
                else
                    return other;

            if (other == null) return this;
                if (c == category.HP) 
                if (HP > other.HP)
                    return this;
                else
                    return other;

            if (other == null) return this;
            if (c == category.CC)
                if (CC > other.CC)
                return this;
            else
                return other;

            if (other == null) return this;
            if (c == category.Cylinders) 
                if (Cylinders > other.Cylinders)
                return this;
            else
                return other;

            if (other == null) return this;
            if (c == category.RPM) 
                if(RPM > other.RPM)
                return this;
            else
                return other;

        

            return null;
        }
        public override string ToString()
        {
            return name + ":\n\tMax Speed: "  + maxspeed 
                + "\n\tZero To Sixty:" + zerotosixty
                + "\n\tHorse Power:" + HP 
                + "\n\tCC:" + CC 
                + "\n\tCylinders:" + Cylinders 
                + "\n\tRPM:" + RPM;

        }
    }

}
