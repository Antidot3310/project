using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shesternia : MonoBehaviour
{

    public int damage = 1;
    public float speedsh;
    public GameObject effect;
    public GameObject sound;

    private float timeBtwSpawnSp;
    public float startTimeBtwSpawnSp;

    private Animator camAnim;
    private void start()
    {
        GameObject go = GameObject.Find("Spawner");
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }


    private void Update()
    {
        if (Time.timeScale == 1f)
        {
            speedsh = GetComponent<Spawner>().speedsh;
            transform.Translate(Vector2.left * speedsh);
        }
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            Instantiate(sound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}
