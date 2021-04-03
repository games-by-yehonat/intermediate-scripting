using UnityEngine;

namespace Statics
{
    public class Player : MonoBehaviour
    {
        public static int playerCount = 0;

        void Start()
        {
            //Increment the static variable to know how many
            //objects of this class have been created.
            playerCount++;
        }
    }
}
