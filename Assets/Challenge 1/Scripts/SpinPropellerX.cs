using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
   public float rotationspeed;
    void Start()
    {
        
    }
    void Update()
    {
       transform.Rotate(Vector3.forward, Time.deltaTime *rotationspeed);  
    }
}
