﻿using UnityEngine;

namespace Events
{
    public class TurnColorScript : MonoBehaviour 
    {
        void OnEnable()
        {
            EventManager.OnClicked += TurnColor;
        }


        void OnDisable()
        {
            EventManager.OnClicked -= TurnColor;
        }


        void TurnColor()
        {
            Color col = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = col;
        }
    }
}