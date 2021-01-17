using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToReversedCam : MonoBehaviour
{
    public bool enteredTrigger = false;

    void OnTriggerStay(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            enteredTrigger = true;

            FindObjectOfType<CameraSwitcher>().SwitchToReversedCam();
                       
        }
    }

  /*  void Update()
    {
        if(enteredTrigger)
        {
            FindObjectOfType<CameraSwitcher>().SwitchToReversedCam();
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
