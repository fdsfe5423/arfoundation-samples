using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private GameManager gm;

    public GameManager.ItemTypes itemType;

    public void Identify()
    {
        foreach (Slime slime in gm.slimes)
        {
            foreach (GameManager.ItemTypes type in slime.items)
            {
                if (type == itemType)
                {
                    slime.isSuspect = false;
                    GetComponent<MeshRenderer>().enabled = false;
                }
            }
        }
    }

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnMouseDown()
    {
        Identify();
    }
}
