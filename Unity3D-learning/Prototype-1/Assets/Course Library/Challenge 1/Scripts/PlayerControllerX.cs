using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 initVal = new Vector3(0, 0, 0);
        this.transform.position = initVal;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, verticalInput * (rotationSpeed * Time.deltaTime));
    }
}
