using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    private void Awake()
    {

        gameOverScreen.SetActive(false);
    }
    public void gameover()
    {
        gameOverScreen.SetActive(true);
    }
    public void restart()
    {
        Playermove.healthamount = 20f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
