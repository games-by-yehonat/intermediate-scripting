using UnityEngine;

namespace TernaryOperator
{
    public class TernaryOperator : MonoBehaviour
    {
        void Start()
        {
            int health = 10;
            string message;

            // This is an example Ternary Operation that choose a message based
            // on the variable "health"
            // bool ? true : false
            message = health > 0 ? "Player is Alive" : health == 0 ? "Player is Barely Alive" : "Player is Dead";
            Debug.Log(message);
        }
    }
}
