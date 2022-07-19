using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] int waitingTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        // we can use variable instead of writing GetComponent<> every time
        GetComponent<MeshRenderer>().enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        

        if(Time.time > waitingTime)
        {
            Debug.Log(waitingTime + " seconds has elapsed");
            GetComponent<MeshRenderer>().enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
