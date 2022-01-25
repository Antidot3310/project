using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public GameObject effect;
    public Text healthDisplay;
    public GameObject panel;
    public GameObject[] sounds;
    public int health=5;

    private Animator camAnim;
    private void start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update()
    {
        healthDisplay.text = health.ToString();
        if (health<=0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            int rand = Random.Range(0, sounds.Length);
            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
        
            int rand = Random.Range(0, sounds.Length);
            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
