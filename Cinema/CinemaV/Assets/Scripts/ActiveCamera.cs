using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour
{
    public Camera camOne;
    public Camera camTwo;
    // Start is called before the first frame update
    void Start()
    {
        camOne.enabled = true;
        camTwo.enabled = false;
        Debug.Log(camTwo.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
         camOne.enabled = true;
        camTwo.enabled = false;
        
        


    }

    private void OnTriggerExit(Collider other)
    {
       camTwo.enabled = true;
        camOne.enabled = false;
    }
}
