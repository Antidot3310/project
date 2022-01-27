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
    public Text scoredisable;


    private Animator camAnim;
    private void start()
    {
        scoredisable = GetComponent<Text>();
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        scoredisable.enabled = true;
    }

    private void Update()
    {
        healthDisplay.text = health.ToString();
        if (health<=0)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            Destroy(gameObject);
            scoredisable.enabled = false;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight && Time.timeScale == 1f)
        {
            int rand = Random.Range(0, sounds.Length);
            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight && Time.timeScale == 1f)
        {
        
            int rand = Random.Range(0, sounds.Length);
            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
