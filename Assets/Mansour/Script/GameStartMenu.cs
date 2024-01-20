using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{



    [Header("Main Menu Buttons")]
    public GameObject[] game;
   
    public GameObject backButton;
    public GameObject AText;
    public GameObject HText;
    public GameObject Set;





    public GameObject[] s;
    public GameObject[] all;
    private int f;
    // Start is called before the first frame update
    void Start()
    {


        //Hook events



    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {

        foreach (var item in game)
        {
            Debug.Log(item);
            item.SetActive(false);
            f++;
        }

       


    }



    public void EnableMainMenu()
    {
        backButton.SetActive(false);


        foreach (var item in all)
        {
            Debug.Log(item);
            item.SetActive(true);
            f++;

        }
        foreach (var item in s)
        {
            Debug.Log(item);
            item.SetActive(false);

        }

    }
    public void EnableOption()
    {
        foreach (var item in all)
        {
            Debug.Log(item);
            item.SetActive(false);
            f++;

        }
        backButton.SetActive(true);
    }
    public void BAbout()
    {
        foreach (var item in all)
        {
            Debug.Log(item);
            item.SetActive(false);
            f++;

        }
        backButton.SetActive(true);
        AText.SetActive(true);
    }
    public void BHow()
    {
        foreach (var item in all)
        {
            Debug.Log(item);
            item.SetActive(false);
            f++;

        }
        backButton.SetActive(true);
        HText.SetActive(true);
    }
    public void BSEt()
    {
        foreach (var item in all)
        {
            Debug.Log(item);
            item.SetActive(false);
            f++;

        }
        backButton.SetActive(true);
        Set.SetActive(true);
    }
}
