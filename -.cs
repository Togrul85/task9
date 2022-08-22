using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Weapon
    {

        private int _capacity;
        private int _theNumberOfBullets;
        private double _combDischargeSecond;
        private string _shootingMode;

        public Weapon(int capacity, int theNumberOfBullets, double combDischargeSecond, string shootingMode)
        {
            Capacity = capacity;
            TheNumberOfBullets = theNumberOfBullets;
            CombDischargeSecond = combDischargeSecond;
            ShootingMode = shootingMode;
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        public int TheNumberOfBullets

        {
            get
            {
                return _theNumberOfBullets;
            }
            set
            {
                if (value >= 0)
                {
                    _theNumberOfBullets = value;
                }

            }


        }
        public double CombDischargeSecond
        {
            get
            {
                return _combDischargeSecond;
            }
            set
            {
                if (value > 0)
                {
                    _combDischargeSecond = value;
                }
            }
        }
        private string ShootingMode
        {
            get
            {
                return _shootingMode;
            }
            set
            {
                if (value == "Single" || value == "Automatic")
                {
                    _shootingMode = value;
                }
            }


        }
        public void Shoot()
        {
            TheNumberOfBullets = TheNumberOfBullets - 1;
            Console.WriteLine("1 shot fired");
        }
        public void Fire()
        {
            double TimeSpentonOneBullet;
            TimeSpentonOneBullet = Capacity / CombDischargeSecond;
            Console.WriteLine(TimeSpentonOneBullet);

            if (ShootingMode == "Single")
            {
                TheNumberOfBullets = TheNumberOfBullets - 1;
            }
            else
            {
                CombDischargeSecond = 0;
            }

        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(Capacity - TheNumberOfBullets);
        }
        public void Reload()
        {
            TheNumberOfBullets = Capacity;
        }
        public void ChangeFireMode()
        {
            if (ShootingMode == "Single")
            {
                ShootingMode = "Automatic";
            }
            else if (ShootingMode == "Automatic")
            {
                ShootingMode= "Single";
            }
        }
        
         


        }
    }

    

    


































