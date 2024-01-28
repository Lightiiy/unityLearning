using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AbstractProjectileBehavior : MonoBehaviour
{
    public float speed = 20;
    public float mapRange = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    private void LateUpdate()
    {
        var position = transform.position;
        Vector3 absolutePosition = new Vector3(Mathf.Abs(position.x), 0, Mathf.Abs(position.z));

        if (absolutePosition.x > mapRange || absolutePosition.z > mapRange)
        {
            Destroy(this.GameObject());
        }
    }
}
