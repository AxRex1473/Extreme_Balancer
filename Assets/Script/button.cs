using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void LoadSceneMode()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void LoadSceneMode1()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadSceneMode2()
    {
        SceneManager.LoadScene("Nivel2");
    }

    public void LoadSceneMode3()
    {
        SceneManager.LoadScene("Nivel3");
    }
}
