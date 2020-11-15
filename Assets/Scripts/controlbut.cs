using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlbut : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj_1;
    public GameObject obj_2;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        obj_1.SetActive(false);
        obj_2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 175, 400f, 150, 200f), "Следующая"))
        {
            add();
            switch (counter)
            {
                case 0:
                    {
                        obj_1.SetActive(false);
                        obj_2.SetActive(false);
                        break;
                    }
                case 1:
                    {
                        obj_1.SetActive(true);
                        obj_2.SetActive(false);
                        break;
                    }
                case 2:
                    {
                        obj_1.SetActive(false);
                        obj_2.SetActive(true);
                        break;
                    }
            }
        }
        if (GUI.Button(new Rect(Screen.width - 175, 200f, 150, 200f), "Предыдущая"))
        {
            take();
            switch (counter)
            {
                case 0:
                    {
                        obj_1.SetActive(false);
                        obj_2.SetActive(false);
                        break;
                    }
                case 1:
                    {
                        obj_1.SetActive(true);
                        obj_2.SetActive(false);
                        break;
                    }
                case 2:
                    {
                        obj_1.SetActive(false);
                        obj_2.SetActive(true);
                        break;
                    }
            }
        }
        if (GUI.Button(new Rect(Screen.width - 175, 25, 150, 150), "Выход "))
        {
            Application.Quit();
        }
    }
    void add()
    {
        counter++;
        counter = counter % 3;
    }
    void take()
    {
        counter--;
        if (counter < 0)
        {
            counter = 2;
        }
    }
}
