using System.Collections;
using UnityEngine;

public class New_Player : MonoBehaviour
{
    public GameObject player;
    public int walk;
    public float time;
    public float time2;
    public float da;
    public GameObject target;
    public bool enemy = false;

    public New_Enemy ensc;
    private void Start()
    {
        ensc = target.GetComponent<New_Enemy>();
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("target");
        Enemy();
    }
    private void Enemy()
    {
        if (walk == 0&&!enemy)
        {
            walk = 0;
            enemy = true;
            ensc.func1();
            
        }
        if (walk > 0)
        {
            enemy = false;
        }
    }
    public void Forw()
    {
        if (walk > 0)
        {
            time2 = 10;
            walk -= 1;

            StartCoroutine(WalkForw());
        }
    }
    public void Back()
    {
        if (walk > 0)
        {
            time2 = 10;
            walk -= 1;
            StartCoroutine(WalkBack());
        }
    }
    public void Rigth()
    {
        if (walk > 0)
        {
            time2 = 10;
            walk -= 1;
            StartCoroutine(WalkRigth());
        }
    }
    public void Left()
    {
        if (walk > 0)
        {
            time2 = 10;
            walk -= 1;
            StartCoroutine(WalkLeft());
        }
    }
    public void NewWalk()
    {
        //walk = Random.Range(1, 6);
        //enemy = false;  
    }
    public IEnumerator WalkForw()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(0, 0, da);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
    }
    public IEnumerator WalkBack()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(0, 0, -da);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }

    }
    public IEnumerator WalkRigth()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(-da, 0, 0);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
    }
    public IEnumerator WalkLeft()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(da, 0, 0);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
    }
}