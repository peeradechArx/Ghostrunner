using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timescore : MonoBehaviour
{
    public  Text Textscore;
    public float score;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            Textscore.text = ((int)score).ToString();
        }
    }
}

