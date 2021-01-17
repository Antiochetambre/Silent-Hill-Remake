using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static bool mapClick = false;
    public GameObject MapUI;
    public Camera cam;

    void Start()
    {
        cam.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(mapClick)
            {
                MapIsOpen();
            }

            else
            {
                MapIsClosed();
            }


        }
        
    }

    void MapIsClosed()
    {
        cam.enabled = true;
        MapUI.SetActive(true);

        Debug.Log("Map opened.");

        Time.timeScale = 0f;

        mapClick = true;

    }

    void MapIsOpen()
    {
        cam.enabled = false;
        MapUI.SetActive(false);
        

        Time.timeScale = 1f;
        
        mapClick = false;

    }

}
