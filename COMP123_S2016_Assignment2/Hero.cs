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
    }
}
