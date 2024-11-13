using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class New_Enemy : MonoBehaviour
{
    public int walk;
    public float time;
    public float time2;
    public float da;
    public New_Player ensc;
    public GameObject player;

    private void Start()
    {
        
    }
    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player_control");
        ensc = player.GetComponent<New_Player>();
    }

    public void Forw()
    {
        time2 = 10;
        StartCoroutine(WalkForw());
    }
    public void Back()
    {
        time2 = 10;
        StartCoroutine(WalkBack());
    }
    public void Rigth()
    {
        time2 = 10;
        StartCoroutine(WalkRigth());
    }
    public void Left()
    {
        time2 = 10;
        StartCoroutine(WalkLeft());
    }
    public void func1()
    {
        if (walk < 15)
        {
            Left();
            walk++;
            ensc.NewWalk();
        }
        else if(walk < 19)
        {
            Forw();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 23)
        {
            Rigth();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 30)
        {
            Forw();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 36)
        {
            Left();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 38)
        {
            Back();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 41)
        {
            Rigth();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 44)
        {
            Back();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 46)
        {
            Left();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 48)
        {
            Forw();
            walk++;
            ensc.NewWalk();
        }
        else if (walk < 51)
        {
            Left();
            walk++;
            ensc.NewWalk();
        }

    }
    public IEnumerator WalkForw()
    {
        while (time2 > 0)
        {
            if (time2 > 0)
            {
                this.transform.localPosition += new Vector3(0, 0, da);
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
                this.transform.localPosition += new Vector3(0, 0, -da);
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
                this.transform.localPosition += new Vector3(-da, 0, 0);
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
                this.transform.localPosition += new Vector3(da, 0, 0);
                time2 -= 1;
                yield return new WaitForSeconds(time);
            }
        }
    }
}