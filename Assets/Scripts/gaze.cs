using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Net;

public class gaze : MonoBehaviour
{
    List<infoBehaviour> infos = new List<infoBehaviour>();
    // Start is called before the first frame update
    void Start()
    {
        infos = FindObjectsOfType<infoBehaviour>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasinfo"))
            {
                OpenInfo(go.GetComponent<infoBehaviour>());
            }
            else if (go.CompareTag("info"))
            { 
                
            }
            else
            {
                CloseALL();
            }
        }
    }

    void OpenInfo(infoBehaviour desiredInfo)
    {
        foreach (infoBehaviour info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }
    void CloseALL()
    {
        foreach (infoBehaviour info in infos)
        {
            info.CloseInfo();
        }
    }
}
