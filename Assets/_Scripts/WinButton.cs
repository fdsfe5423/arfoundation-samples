using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinButton : MonoBehaviour
{
    private GameManager gm;
    public Slime slime;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Press()
    {
        if (slime.isSuspect)
        {
            if (gm.target == slime)
            {
                gm.Win();
            }
            else
            {
                gm.GameOver();
            }
        }
    }
}
