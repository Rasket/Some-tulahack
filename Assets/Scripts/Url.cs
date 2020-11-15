using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Url : MonoBehaviour
{
    // Start is called before the first frame update
    public void onUrl()
    {
        Application.OpenURL("https://www.astonmartin.com/en-us/");
    }
    public void onUrlFerrari()
    {
        Application.OpenURL("https://www.ferrari.com/en-RU");
    }
}
