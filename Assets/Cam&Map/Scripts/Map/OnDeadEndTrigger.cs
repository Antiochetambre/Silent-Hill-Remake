using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeadEndTrigger : MonoBehaviour
{
    public GameObject scribble;
    private void OnTriggerEnter(Collider player)
    {

        if (player.CompareTag("Player"))
        {
            scribble.SetActive(true);
            Debug.Log("dead end");
        }
    }
}
