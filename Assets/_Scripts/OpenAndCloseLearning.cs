using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseLearning : MonoBehaviour
{
    public GameObject obj;
    public bool iOpen;

    private void Update()
    {
        if(iOpen)
        {
            obj.SetActive(true);
        }
        if(!iOpen)
        {
            obj.SetActive(false);
        }
    }
    public void Open()
    {
        iOpen = true;
    }
    public void Close()
    {
        iOpen = false;
    }
}
