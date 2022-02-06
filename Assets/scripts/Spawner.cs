using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] shesterniaVariants;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, shesterniaVariants.Length);
            Instantiate(shesterniaVariants[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

    }
}
