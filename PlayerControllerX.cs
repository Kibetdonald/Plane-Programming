using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = .2f;
    private float verticalInput;
    private float rotationSpeed = 40f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed);
        transform.Rotate(Vector3.right * Time.deltaTime * -verticalInput * rotationSpeed);
    }
}

