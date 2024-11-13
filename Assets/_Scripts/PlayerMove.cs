using System.Collections;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float walk;
    public float time;
    public float time2;
    public float da;
    public float daMinus;
    public float newRotation;
    public float speedRot;  

    private void Update()
    { 
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Forw()
    {
        if(walk >0)
        {
            time2 = 10;
            StartCoroutine(WalkForw());
        } 
    }
    public void Back()
    {
        if (walk > 0)
        {
            time2 = 10;
            StartCoroutine(WalkBack());
        }
    }
    public void Rigth()
    {
        if (walk > 0)
        {
            time2 = 10;
            StartCoroutine(WalkRigth());
        }
    }
    public void Left()
    {
        if (walk > 0)
        {
            time2 = 10;
            StartCoroutine(WalkLeft());
        }
    }
    public IEnumerator WalkForw()
    {
        while(time2 > 0)
        {
            if(time2 > 0)
            {
            player.transform.localPosition += new Vector3(0, 0, da);
            time2 -= 1;
            yield return new WaitForSeconds(time);
            }
        }
        walk--;
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
        walk--;
    }
    public IEnumerator WalkRigth()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(-daMinus, 0, 0);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
        walk--;
    }
    public IEnumerator WalkLeft()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                player.transform.localPosition += new Vector3(daMinus, 0, 0);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
        walk--;
    }
}
