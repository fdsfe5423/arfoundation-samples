using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public int iWalk;
    public GameObject[] agy;    

    public void Walk()
    {
        switch
        (iWalk)
        {
            case 0:
                gameObject.transform.position = agy[0].transform.position;
                gameObject.transform.rotation = agy[0].transform.rotation;
                iWalk++;
                break;
            case 1:
                gameObject.transform.position = agy[1].transform.position;
                gameObject.transform.rotation = agy[1].transform.rotation;
                iWalk++;
                break;
            case 2:
                gameObject.transform.position = agy[2].transform.position;
                gameObject.transform.rotation = agy[2].transform.rotation;
                iWalk++;
                break;
            case 3:
                gameObject.transform.position = agy[3].transform.position;
                gameObject.transform.rotation = agy[3].transform.rotation;
                iWalk++;
                break;
            case 4:
                gameObject.transform.position = agy[4].transform.position;
                gameObject.transform.rotation = agy[4].transform.rotation;
                iWalk++;
                break;
            case 5:
                gameObject.transform.position = agy[5].transform.position;
                gameObject.transform.rotation = agy[5].transform.rotation;
                iWalk++;
                break;
        }
    }
}