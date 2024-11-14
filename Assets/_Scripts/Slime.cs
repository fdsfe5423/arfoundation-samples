using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private GameManager gm;
    
    public GameManager.ItemTypes[] items = new GameManager.ItemTypes[3];
    public bool isSuspect = true;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
