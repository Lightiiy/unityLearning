using Unity.VisualScripting;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject animalVariant;

    public float[] spawnRange = { -25, 25 } ;

    public float startDelay, spawnInterval;
    //ToDO -> create enum of functions for movement. Add movement behavior as a list of functions from 
    //external script
    // private [] animalBehavior = [this.movement];
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 random = new Vector3(Random.Range(spawnRange[0],spawnRange[1]), 0, 20);
        this.transform.position = random;
        this.transform.Rotate(Vector3.up, 180);
        
        InvokeRepeating(nameof(this.SpawnAnimal), this.startDelay, this.spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     _movement();   
    }

    private void _movement()
    {
        float currentPosition = this.transform.position.x;
        if (currentPosition > spawnRange[1])
        {
            this.transform.Translate( Vector3.left * Time.deltaTime);
        }
        this.transform.Translate(Vector3.right * Time.deltaTime);
    }

    private void SpawnAnimal()
    {
        Transform spawnerTransform = this.transform;
        Instantiate(animalVariant, spawnerTransform.position, spawnerTransform.rotation);
    }
}
