using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public GameObject playerObject;

    public Vector3 cameraOffset = new Vector3(5, 0, 5);
// Start is called before the first frame update
    void Start()
    {
        Vector3 initPosition = playerObject.transform.position;
        this.transform.position = initPosition + cameraOffset;
    }

    // Update is called once per frame

    void Update() {}

    // LateUpdate is called once per frame after the Update function
    void LateUpdate()
    {
        this.transform.position = playerObject.transform.position + cameraOffset;
    }
}
