using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public enum ItemTypes
    {
        Glasses/*����*/, Moustache/*���*/, Headphones/**/, Cap/*�����*/,
        Hat/*�����*/, Donut/*������*/, Mask/*�����*/
    }
    public ItemTypes[] trueItems;

    public Slime[] slimes;
    public Slime target;

    public Item[] items;
    public List<Transform> placesItems;

    private void Awake()
    {
        slimes = FindObjectsOfType<Slime>();
        target = slimes[Random.Range(0, slimes.Length)];
        trueItems = target.items;

        items = FindObjectsOfType<Item>();
        foreach (Item item in items)
        {
            int a;
            if (placesItems.Count >= 1)
            {
                a = Random.Range(0, placesItems.Count - 1);
            }
            else
            {
                a = 0;
            }
            item.gameObject.transform.position = placesItems[a].position;
            placesItems.RemoveAt(a);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
