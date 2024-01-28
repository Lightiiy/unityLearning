using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 5f;

    private bool spawnDog = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnDog)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); 
                SetFlagForDuration();
            }
        }
    }

    private void SetFlagForDuration()
    {
        StartCoroutine(FlagTimer(cooldown));
    }

    private IEnumerator FlagTimer(float duration)
    {
        spawnDog = false;

        yield return new WaitForSeconds(duration);

        spawnDog = true;
    }

}
