using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

/*
 * Author - Jake Yeatman
 * Date Created - 28/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class Menu_Interactions : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenScene(string menuName)
    {
        SceneManager.LoadScene(menuName);
    }
}
