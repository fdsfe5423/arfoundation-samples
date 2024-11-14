using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public enum ItemTypes
    {
        Glasses/*Очки*/, Moustache/*Усы*/, Headphones/**/, Cap/*Кепка*/,
        Hat/*Шляпа*/, Donut/*Пончик*/, Mask/*Маска*/
    }
    public ItemTypes[] trueItems;

    public Slime[] slimes;
    public Slime target;

    public Item[] items;
    public List<Transform> placesItems;

    private void Start()
    {
        slimes = FindObjectsOfType<Slime>();
        target = slimes[Random.Range(0, slimes.Length)];

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
}
