using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public float timeLeft = 20;

    bool gameOver = false;
    bool win =false;

    public GameObject wintext;
    public GameObject gameOverText;
    public GameObject ball;
    public PlayerController player;

    public TextMeshProUGUI timerText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft >=0 && !win)
        {
            timeLeft -= Time.deltaTime;

            timerText.text = timeLeft.ToString("F1");
        }
        if(timeLeft <=0 && !win)
        {
            GameOver();
        }
    }
    public void GameWin()
    {
        win = true;
        wintext.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);
    }
    public void GameOver()
    {
        gameOverText.SetActive(true);
        player.enabled = false;
        gameOver = false;
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
