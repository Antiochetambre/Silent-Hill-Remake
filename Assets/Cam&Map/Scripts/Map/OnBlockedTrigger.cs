using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBlockedTrigger : MonoBehaviour
{
    public GameObject scribble;
    private void OnTriggerEnter(Collider player)
    {

        if (player.CompareTag("Player"))
        {
             scribble.SetActive(true);
            Debug.Log("blocked");
        }
    }
}
