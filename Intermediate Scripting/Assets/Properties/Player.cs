using System;

namespace Properties
{
    public class Player
    {
        // Member variables can be referred to as
        // fields
        private int _experience;

        // Experience is a basic property
        public int Experience
        {
            get
            {
                // Some other code
                return _experience;
            }
            set
            {
                // Some other code
                _experience = value;
            }
        }

        // Level is a property that coverts experience
        // points into the level of a player automatically
        public int Level
        {
            get
            {
                return _experience / 1000;
            }
            set
            {
                _experience = value * 1000;
            }
        }

        // This is an example of an auto-implementad
        // property
        public int Health { get; set; }
    }
}
