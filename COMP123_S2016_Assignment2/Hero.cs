using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment2
{
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES ++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPERTIES +++++++++++++++++

        /**
         * <summary>
         * This is a property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
        public string Name
        {
            get 
            { 
                return this._name; 
            }
            set 
            { 
                this._name = value; 
            }
        }

        // CONSTRUCTORS +++++++++++++++++

        /**
        * <summary>
        * This is a constructor that takes Hero as a parameter and passes 
        * it to the _name private instance variable 
        * </summary>
        * 
        * @contructor Hero
        * @param {string} name
        */
        public Hero(string Name)
        {
            this._name = Name;
            generateAbilities(80, 90, 100);
        }

        // PRIVATE METHODS ++++++++++++++

        /**
         * <summary> 
         * This method takes strength, speed and health parameters. 
         * It assigns the local strenght value to the Strength property.
         * It assigns the local speed value to the Speed property. 
         * It assigns the local health value to the Health property.
         * </summary>
         * 
         * @private 
         * @method _generateAbilities 
         * @returns {void}
         */
        public void generateAbilities(int strength, int speed, int health)
        {
            this.Strength = strength;
            this.Speed = speed;
            this.Health = health;
        }

        /**
         * <summary>
         * This method will determine if the Hero hits 
         * </summary>
         * 
         * @private 
         * @method _hitAttempt 
         * @returns {void}
         */
        private void _hitAttempt(bool hitAttempt)
        {
            int onePunch = Strength * 2;

            if (hitAttempt)
            {
                Console.WriteLine("");
                Console.WriteLine(" Man Down by {0},  Life Source {1} ", onePunch * 2, this.Health);
            }
            else
            {
                Console.WriteLine("*** Hit attemped. Show all abilities now ***");
                Console.WriteLine("  Health: {0}, Strength: {1}, Speed: {2} ", this.Health, this.Strength, this.Speed);
                Console.WriteLine("--------------------------------------------------------");
            }
        }


        /**
         * <summary>
         * This method calculates by multiplying the Hero's strength property 
         * by a number between 1 and 6 
         * </summary>
         * 
         * @private
         * @method _hitDamage 
         * @return void 
         */
        private void _hitDamage(int hitDamage)
        {
            int onePunch = Strength * 2;
            Console.WriteLine(" Man Down by {0},  Life Source {1} ", onePunch * 5, this.Health - onePunch);
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        // PUBLIC METHODS +++++++++

        /**
        * <summary> 
        * This method outputs the _name, _strength, _speed, and _health values
        * in the following. 
        * </summary>
        * 
        * @method Show
        * @returns {void} 
        */
        public void Show()
        {
            Console.WriteLine("                " + this.Name);
            Console.WriteLine("**********************************************");
            Console.WriteLine("               Strength: " + this.Strength);
            Console.WriteLine("                Speed: " + this.Speed);
            Console.WriteLine("               Health: " + this.Health);
            Console.WriteLine("**********************************************");
        }
    }
}
