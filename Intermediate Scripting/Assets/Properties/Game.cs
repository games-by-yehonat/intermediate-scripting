using UnityEngine;

namespace Properties
{
    public class Game : MonoBehaviour
    {
        private void Start()
        {
            Player myPlayer = new Player();
            
            // Properties can be used just like variables
            int x = myPlayer.Experience;
            myPlayer.Experience = 15;
        }
    }
}