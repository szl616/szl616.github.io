using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        static public bool PlayerInCar = false;
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            if (PlayerInCar) { 
                // pass the input to the car!
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");
            }

        }

        void OnTriggerEnter (Collider col)
        {
            Debug.Log("Someone entered the zone: "+col);
            if(col.gameObject.tag == "Player")
            {
                Debug.Log("Player entered");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    PlayerInCar = true;
                    BroadcastMessage("EnterCar");
                    Debug.Log("Broadcasted");
                }
            }
        }
    }
}
