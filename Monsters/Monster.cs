using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    public class Monster
    {
        public enum EmotionalState
        {
            none,
            happy,
            sad,
            angry,
            bored
        }

        #region FIELDS
        private string _name;
        private int _age;
        private EmotionalState _attitude;
        #endregion

        #region PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public EmotionalState Attitude
        {
            get { return _attitude; }
            set { _attitude = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        #endregion








    }
}
