using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerHandler : MonoBehaviour
{
    public GameObject[] animalVariants;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var animal in animalVariants)
        {
            GameObject variantSpawner = new GameObject(animal.name);
            AnimalSpawner animalSpawner = variantSpawner.AddComponent<AnimalSpawner>();

            animalSpawner.animalVariant = animal;
            animalSpawner.startDelay = 2f;
            animalSpawner.spawnInterval = 5f;
            
            variantSpawner.transform.parent = transform;
            // Instantiate();
        }
    }
    
    
}
