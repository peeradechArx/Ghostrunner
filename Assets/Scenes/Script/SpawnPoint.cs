using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Devil;

    private void Start()
    {
        Instantiate(Devil, transform.position, Quaternion.identity);
    }
}

