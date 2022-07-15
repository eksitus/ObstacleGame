using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    [SerializeField]float yValue = 0.001f;
    [SerializeField] float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    { 
        float xValue = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
