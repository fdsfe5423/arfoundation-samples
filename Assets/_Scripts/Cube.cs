using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject player;
    public int countWalk;
    public int random;
    public Animator animator;
    public AudioSource audio;

    private void Update()
    {
        player = GameObject.Find("Canvas");
        if (countWalk == 1)
        {
            animator.SetBool("1", true);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
            animator.SetBool("6", false);
            Invoke("StopAnim", 0.5f);
        }
        if (countWalk == 2)
        {
            animator.SetBool("1", false);
            animator.SetBool("2", true);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
            animator.SetBool("6", false);
            Invoke("StopAnim", 0.5f);
        }
        if (countWalk == 3)
        {
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", true);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
            animator.SetBool("6", false);
            Invoke("StopAnim", 0.5f);
        }
        if (countWalk == 4)
        {
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", true);
            animator.SetBool("5", false);
            animator.SetBool("6", false);
            Invoke("StopAnim", 0.5f);
        }
        if (countWalk == 5)
        {
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", true);
            animator.SetBool("6", false);
            Invoke("StopAnim", 0.5f);
        }
        if (countWalk == 6)
        {
            animator.SetBool("1", false);
            animator.SetBool("2", false);
            animator.SetBool("3", false);
            animator.SetBool("4", false);
            animator.SetBool("5", false);
            animator.SetBool("6", true);
            Invoke("StopAnim", 0.5f);
        }
    }

    public void DropCube()
    {
        if (player.GetComponent<New_Player>().walk <= 0)
        {
            StartCoroutine(IPublic());
        }
    }
    public IEnumerator IPublic()
    {
        while(countWalk == random)
        {
            random = Random.Range(1, 7);
            yield return new WaitForSeconds(0);
        }
        audio.Play();
        countWalk = random;
        player.GetComponent<New_Player>().walk = countWalk;
    }
}
