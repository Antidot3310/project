using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shesternia : MonoBehaviour
{

    public int damage = 1;
    public float speedsh;
    public GameObject effect;
    public GameObject sound;
    private void Update()
    {
        if (Time.timeScale == 1f)
        {
            transform.position = new Vector2(transform.position.x - speedsh, transform.position.y);

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
