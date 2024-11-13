using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject move;
    public int da;

    public void Forw()
    {
        move.transform.localPosition = new Vector3(0,0,da);
    }
    public void Back()
    {
        move.transform.localPosition = new Vector3(0, 0, -da);
    }
    public void Right()
    {
        move.transform.localRotation = new Quaternion(0,90,0,0);
    }
}
