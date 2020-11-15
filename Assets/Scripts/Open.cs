using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("choosescene");
    }
    public void StartAston()
    {
        SceneManager.LoadScene("AstonMartinscene");
    }
    public void StartAstonAr()
    {
        SceneManager.LoadScene("AstonAr");
    }
    public void StartFerrari()
    {
        SceneManager.LoadScene("Ferrari scene");
    }
}
