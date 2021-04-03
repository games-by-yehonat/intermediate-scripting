using System; //This allows the IComparable Interface

//This is the class you will be storing
//in the different collections. In order to use
//a collection's Sort() method, this class needs to
//implement the IComparable interface.
namespace ListsAndDictionaries
{
    public class BadGuy : IComparable<BadGuy>
    {
        public string name;
        public int power;

        public BadGuy(string newName, int newPower)
        {
            name = newName;
            power = newPower;
        }

        public int CompareTo(BadGuy other)
        {
            if(other == null)
            {
                return 1;
            }

            return power - other.power;
        }
    }
}
