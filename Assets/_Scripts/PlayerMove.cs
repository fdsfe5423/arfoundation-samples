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

    private void Start()
    {
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Forw()
    {
        if(walk >0)
        {
            StartCoroutine(Walk());
        } 
    }
    public IEnumerator Walk()
    {
        while(time2 > 0)
        {
            da += walk;
            player.transform.localPosition += new Vector3(daMinus, 0, da);
            time2 -= 1;
            yield return new WaitForSeconds(time);
        }       
    }
}
