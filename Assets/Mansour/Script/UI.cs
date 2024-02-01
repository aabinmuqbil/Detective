using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void Map1()
    {
        Debug.Log("Butten Clicked");
        SceneManager.LoadScene("Victory");
    }
    public void INvistgationRoom()
    {
        SceneManager.LoadScene("Test");
    }
    public void Eixit()
    {
        Application.Quit();
    }
}
