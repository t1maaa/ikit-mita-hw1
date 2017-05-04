using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgCat.Model
{
    class Cat
    {
        private int _health;

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public int Health => _health;

        public int Age { get; }

        public string Color()
        {
            if (this._health < 3)
            {
                return "Red";
            }

            else if (this._health > 5)
            {
                return "Green";
            }

            else if (this._health == 5)
            {
                return "Yellow";
            }

            else return "White";

        }

        public void Feed()
        {
            this._health++;
        }

        public void Punish()
        {
            this._health--;
        }

        public Cat(int age)
        {
            this.Age = age;
            this._health = 6;
        }
    }
}
