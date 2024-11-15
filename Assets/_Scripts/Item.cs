using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Item : MonoBehaviour
{
    private GameManager gm;
    private GameObject deshefrator;

    public GameManager.ItemTypes itemType;
    private bool isTrueItem;

    public void Identify()
    {
        foreach (Slime slime in gm.slimes)
        {
            if ((itemType == slime.items[0]) || (itemType == slime.items[1]) || (itemType == slime.items[2]))
            {
                if ((itemType != gm.trueItems[0]) && (itemType != gm.trueItems[1]) && (itemType != gm.trueItems[2]))
                {
                    slime.isSuspect = false;
                    slime.gameObject.SetActive(false);
                }
            }
        }
    }

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Anim());
        }
    }

    IEnumerator Anim()
    {
        GetComponent<MeshCollider>().enabled = false;
        yield return new WaitForSeconds(10f);
        Identify();
    }
}
