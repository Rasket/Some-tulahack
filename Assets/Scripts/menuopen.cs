using UnityEngine;
using UnityEngine.Events;

public class menuopen : MonoBehaviour
{
    public Animator menu_button;
    private bool isFirst = false;
    void Start() {
       menu_button.enabled = false;
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
            if (Input.GetKey(KeyCode.Escape))
                menu_button.SetBool("isHidden", true);
    }

    public void click(){
        if (!isFirst){
            menu_button.enabled = true;
            isFirst = true;
        }
        else if (menu_button.GetBool("isHidden"))
            menu_button.SetBool("isHidden", false);
        else
            menu_button.SetBool("isHidden", true);
    }
}
