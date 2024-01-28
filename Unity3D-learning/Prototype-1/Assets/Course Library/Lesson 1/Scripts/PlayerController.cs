using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;

    public float turnSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical= Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 carVelocity = Vector3.forward * (speed * vertical);
        float carRotation =  turnSpeed * horizontal;
        
        this.transform.Translate(carVelocity* Time.deltaTime);   
        this.transform.Rotate(Vector3.up, carRotation);
    }
}
