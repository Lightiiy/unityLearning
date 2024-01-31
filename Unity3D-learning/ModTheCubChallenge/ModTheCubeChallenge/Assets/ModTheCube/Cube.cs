using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private Material material; 
    void Start()
    {
        transform.position = new Vector3(0,0,0);
        
        material = Renderer.material;

        material.color = new Color(0, 0, 0);
    }
    
    void Update()
    {
        float sinVal = Mathf.Sin(Time.time * 2) * 3;

        float positionY = Jumping(sinVal);

        float scaleY = Squish(sinVal);

        float scaleX = Spread(sinVal);

        float scaleZ = Spread(sinVal);

        Vector3 finalPosition = new Vector3(0, positionY, 0);
        Vector3 finalScale = new Vector3(scaleX, scaleY, scaleZ);
        transform.position = finalPosition;
        transform.localScale = finalScale;
        material.color = Rainbow();
    }

    private float Jumping(float val)
    {
        if (val <= (Renderer.bounds.size.y)/2)
        {
            
            return (Renderer.bounds.size.y)/2;
        }

        return val ;

    }

    private float Squish(float val)
    {
        if (val > 0)
        {
            return 1;
        }
    
        return val >= -0.90 ? val + 1 : 0.1f ;
    }

    private float Spread(float val)
    {
        if (val > 0)
        {
            return 1;
        }

        return Mathf.Abs(val) + 1;
    }

    private Color Rainbow()
    {
        float red = Mathf.Sin(Time.time);
        float blue = Mathf.Sin(Time.time + (Mathf.PI) / 3);
        float green = Mathf.Sin(Time.time + (Mathf.PI * 2) / 3);

        return new Color(red, green, blue);
    }
}
