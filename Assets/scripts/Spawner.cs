using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] shesterniaVariants;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float maxspeedsh;
    public float decreasespeedsh;
    public float speedsh;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, shesterniaVariants.Length);
            Instantiate(shesterniaVariants[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (speedsh < maxspeedsh)
            {
                speedsh += decreasespeedsh;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

    }
}
