using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM00 : MonoBehaviour
{

    public void LoadOne()
    {
        SceneManager.LoadScene("01");
    }
    public void LoadTwo()
    {
        SceneManager.LoadScene("02");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
