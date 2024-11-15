using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Item : MonoBehaviour
{
    private GameManager gm;
    private GameObject deshefrator;
    [SerializeField] Material m;
    [SerializeField] GameObject i;
    [SerializeField] bool isTrueItem = false;
    private bool b = false;

    public GameManager.ItemTypes itemType;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        deshefrator = GameObject.Find("Deshefrator");
        m.color = Color.black;
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
        print("0");
        if (!b)
        {
            b = true;
            if ((gm.trueItems[0] == itemType) || (gm.trueItems[1] == itemType) || (gm.trueItems[2] == itemType))
            {
                isTrueItem = true;
            }
            print("1");
            GetComponent<MeshRenderer>().enabled = false;
            deshefrator.GetComponent<Animator>().SetTrigger("D");
            yield return new WaitForSeconds(1f);
            print("2");
            if (isTrueItem)
            {
                m.color = Color.green;
            }
            else
            {
                m.color = Color.red;
            }
            yield return new WaitForSeconds(0.5f);
            print("3");
            i.SetActive(true);
            yield return new WaitForSeconds(1f);
            foreach (Slime _slime in gm.slimes)
            {
                if ((itemType == _slime.items[0]) || (itemType == _slime.items[1]) || (itemType == _slime.items[2]))
                {
                    if ((itemType != gm.trueItems[0]) && (itemType != gm.trueItems[1]) && (itemType != gm.trueItems[2]))
                    {
                        _slime.isSuspect = false;
                        _slime.gameObject.SetActive(false);
                    }
                }
            }
            m.color = Color.black;
            i.SetActive(false);
            b = false;
            print("4");
            gameObject.SetActive(false);
        }
    }   
}
