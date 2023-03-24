using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed;
    public float increment;
    public float maxY;
    public float minY;
    private Vector2 targetPos;
    public int health = 3;
    public GameObject Effect;
    public Text healthDisplay;
    public GameObject DisplayOver;
    public GameObject spawn;
    private void Update()
    {
        
         if (health <= 0)
        {
            spawn.SetActive(false);
            DisplayOver.SetActive(true);
            Destroy(gameObject);
         }
        healthDisplay.text = health.ToString();
        transform.position = Vector2.MoveTowards(transform.position,targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}
