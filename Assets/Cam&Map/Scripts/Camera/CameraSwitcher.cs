using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{


    public bool normalCam = false;
    public bool upperCam = false;
    public bool reversedCam = false;

    public Transform[] views;
    public float transitionSpeed = 0.5f;
    Transform currentView;

    /*  void Awake()
      {
          NormalCam.SetActive(true);
      }*/
    /* public void Start()
     {
         normalCam = true;

         upperCam = false;
         reversedCam = false;

     }*/
    public void SwitchToNormalCam()
    {
        upperCam = false;
        reversedCam = false;

        normalCam = true;

    }

    public void SwitchToUpperCam()
    {
        reversedCam = false;
        normalCam = false;

        upperCam = true;

    }
    public void SwitchToReversedCam()
    {
        upperCam = false;
        normalCam = false;

        reversedCam = true;

        transitionSpeed = 1f;

    }

  
    void Update()
    {
        if(normalCam == true)
        { 
            currentView = views[0];
        }
        
        if(upperCam == true)
        {
            currentView = views[1];
        }

        if (reversedCam == true)
        {
            currentView = views[2];
        }
              

    }



    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3
            (
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
            );

        transform.eulerAngles = currentAngle;
    }

}