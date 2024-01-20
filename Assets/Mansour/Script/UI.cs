using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void Map1()
    {
        SceneManager.LoadScene("main");
    }
    public void Eixit()
    {
        Application.Quit();
    }
}
