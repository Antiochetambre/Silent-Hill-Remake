using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Transform target;
    bool isPlaying;

    public AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();         
    }
    
    
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(movementX, 0.0f, movementY);

        transform.position += direction * speed;

        if(Vector3.Distance(transform.position, target.position) < 15 && !audioSource.isPlaying)
        {
            audioSource.Play();
            
        }

        audioSource.volume = 6 / Vector3.Distance(transform.position, target.position);
    }

    
    
     
}
