using System;
using UnityEngine;

namespace Delegates
{
    public class MulticastScript : MonoBehaviour 
    {
        delegate void MultiDelegate();
        MultiDelegate myMultiDelegate;
        
        void Start () 
        {
            myMultiDelegate += PowerUp;
            myMultiDelegate += TurnRed;

            if(myMultiDelegate != null)
            {
                myMultiDelegate();
            }
            
            myMultiDelegate -= PowerUp;
            myMultiDelegate -= TurnRed;
        }

        void PowerUp()
        {
            print ("Orb is powering up!");
        }

        void TurnRed()
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
