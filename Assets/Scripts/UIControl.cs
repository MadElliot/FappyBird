using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {
    public int level = 1;

    public Text highestScore;
    public Text scoreText;
    public GameObject gameoverObj;
    public GameObject restartBtn;
    public GameObject quitBtn;
    int hs = 0;
    public void GameOver()
    {
        gameoverObj.SetActive(true);
        restartBtn.SetActive(true);
        quitBtn.SetActive(true);
        highestScore.enabled = true;
        Debug.Log(highestScore.enabled);
        if (level==1)
        {
            highestScore.text = "历史最高分：" + PlayerPrefs.GetInt("HS");
        }
        if (level==2)
        {
            highestScore.text = "历史最高分：" + PlayerPrefs.GetInt("HS1");
        }
    }

    public void SetScore()
    {
        GM.score += 10;       
        scoreText.text = "Score:" + GM.score;
        if (level == 1)
        {
            if (GM.score > PlayerPrefs.GetInt("HS"))
            {
                PlayerPrefs.SetInt("HS", GM.score);
            }
        }
        if (level == 2)
        {
            if (GM.score > PlayerPrefs.GetInt("HS1"))
            {
                PlayerPrefs.SetInt("HS1", GM.score);
            }
        }
       
    }

    public void Restart()
    {
        GM.score = 0;
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(00);
    }
}
