using System;
using UnityEngine;

namespace Quaternions
{
    public class GravityScript : MonoBehaviour 
    {
        public Transform target;
        
        void Update () 
        {
            Vector3 relativePos = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);

            Quaternion current = transform.localRotation;

            transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
            transform.Translate(0, 0, 3 * Time.deltaTime);
        }
    }

    public class SomeClass : MonoBehaviour
    {
        private void Start()
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
