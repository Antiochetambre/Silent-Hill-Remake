using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToUpperCam : MonoBehaviour
{
    public bool enteredTrigger = false;

    void OnTriggerStay(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            enteredTrigger = true;

            FindObjectOfType<CameraSwitcher>().SwitchToUpperCam();

        }
    }

    /*void Update()
    {
        if (enteredTrigger)
        {
            FindObjectOfType<CameraSwitcher>().SwitchToUpperCam();
        }


    }*/
    void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            enteredTrigger = false;

            FindObjectOfType<CameraSwitcher>().SwitchToNormalCam();
        }
    }

}
