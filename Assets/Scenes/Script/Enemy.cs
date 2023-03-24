using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject effect;
    //public Transform spawn;
    public float respawnTime = 2f;
    public int damage = 1;
   

    void Update()
    {
       
            transform.Translate(speed * Time.deltaTime * Vector2.left);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
  
        if (other.gameObject.tag == "border")
        {
            Destroy(this.gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().health-= damage;
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
        
    }
}
