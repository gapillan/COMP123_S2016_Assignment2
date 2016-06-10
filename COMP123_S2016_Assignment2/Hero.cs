using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment2
{
    /**
     * <summary>
     * This class defines a Hero with special abilities  
     * </summary> 
     * 
     *@class Hero 
     */
    class Hero
    {
        // creating an instance Random number 
        Random random = new Random();

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

        /**
         * <summary>
         * This is a public property for our private _strength field 
         * </summary>
         * @property {int} Strength
         */
        public int Strength
        {
            get
            {
                return this._strength;
            }
            set
            {
                this._strength = value;
            }
        }


        /**
         * <summary>
         * This is a public property for our private _speed field 
         * </summary>
         * @property {int} Speed
         */
        public int Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
       * <summary>
       * This is a public property for our private _health field 
       * </summary>
       * @property {int} Health
       */
        public int Health
        {
            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
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
            generateAbilities();
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
        public void generateAbilities()
        {
            this.Strength = random.Next(1, 135);
            this.Speed = random.Next(1, 125);
            this.Health = random.Next(1, 145);
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
        private bool _hitAttempt()
        {
            if (random.Next(1, 6)== 3)
            {
                Console.WriteLine("");
                Console.WriteLine(" Hits attemped by {0}", this.Name);
                return true; 
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("  " + this.Name + " did not get any damaged hits");
                Console.WriteLine("------------------------------------------------");
                return false;
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
        private int _hitDamage(int strength)
        {
            int damageAttempted;
            int randomNumber = random.Next(1, 7);
            damageAttempted = strength * randomNumber;
            Console.WriteLine(" Damaged {0}", damageAttempted);
            Console.WriteLine("-----------------------------------------------------------");
            return strength;
        }

        // PUBLIC METHODS +++++++++

        public void Fight()
        {
            if (_hitAttempt())
            {
                _hitDamage(this._strength);
            }
            else
            {

            }
        }

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
            Console.WriteLine("                " + _name);
            Console.WriteLine("**********************************************");
            Console.WriteLine("               Strength: " + _strength);
            Console.WriteLine("                Speed: " + _speed);
            Console.WriteLine("               Health: " + _health);
            Console.WriteLine("**********************************************");
        }
    }
}
