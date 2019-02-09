using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float Motorforce, Steerforce, BrakeForce;
    public WheelCollider FL_Wheel, FR_Wheel, BL_Wheel, BR_Wheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * Motorforce;
        float horizontal = Input.GetAxis("Horizontal") * Steerforce;

        BR_Wheel.motorTorque = vertical;
        BL_Wheel.motorTorque = vertical;

        FL_Wheel.steerAngle = horizontal;
        FR_Wheel.steerAngle = horizontal;

        if (Input.GetKey(KeyCode.Space))
        {
            BL_Wheel.brakeTorque = BrakeForce;
            BR_Wheel.brakeTorque = BrakeForce;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            BL_Wheel.brakeTorque = 0;
            BR_Wheel.brakeTorque = 0;
        }

        if (Input.GetAxis("Vertical") == 0)
        {
            BL_Wheel.brakeTorque = BrakeForce;
            BR_Wheel.brakeTorque = BrakeForce;
        }

        else
        {
            BL_Wheel.brakeTorque = 0;
            BR_Wheel.brakeTorque = 0;
        }
        
    }
}
