using UnityEngine;

namespace MethodOverloading
{
    public class SomeOtherClass : MonoBehaviour 
    {
        void Start () 
        {
            SomeClass myClass = new SomeClass();

            myClass.Add (1, 2);
            myClass.Add ("Hello ", "World");
        }
    }
}
