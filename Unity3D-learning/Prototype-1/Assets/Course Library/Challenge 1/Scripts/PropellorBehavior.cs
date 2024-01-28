using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PropellorBehavior : MonoBehaviour
{
    private float planeObjectTransform;

    private float rotationalSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.planeObjectTransform = this.transform.parent.rotation.x;
        float rotation = this.planeObjectTransform + 180;
        float propellerSpeed = Mathf.Sin(rotation);

        this.transform.Rotate(Vector3.forward, propellerSpeed * rotationalSpeed);        
    }
}
