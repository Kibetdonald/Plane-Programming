using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // public var propSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(transform.forward ,40);
        // transform.Rotate(Vector3.forward propSpeed Time.deltaTime);
        
    }
}