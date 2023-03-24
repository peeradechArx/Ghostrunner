using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
        public void RestartButton() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

}
