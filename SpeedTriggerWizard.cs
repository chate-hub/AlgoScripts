using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriggerWizard : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Increase the player's running speed
        other.GetComponent<ThirdPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Decrease the player's running speed
        other.GetComponent<ThirdPersonMovement>().runSpeed /= speedFactor;
    }
}
