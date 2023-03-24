using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Devil;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float DCtime;
    public float minTime = 0.65f;


    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, Devil.Length);
            Instantiate(Devil[rand], transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= DCtime;
            }
            
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
