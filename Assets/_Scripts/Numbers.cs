using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    [SerializeField] List<GameObject> numbers;
    [SerializeField] List<GameObject> buttons;
    [SerializeField] New_Player p;

    private void Update()
    {
        switch (p.walk)
        {
            case 0:
                Hide(false);
                break;
            case 1:
                Hide(true);
                numbers[0].SetActive(true);
                break;
            case 2:
                Hide(true);
                numbers[1].SetActive(true);
                break;
            case 3:
                Hide(true);
                numbers[2].SetActive(true);
                break;
            case 4:
                Hide(true);
                numbers[3].SetActive(true);
                break;
            case 5:
                Hide(true);
                numbers[4].SetActive(true);
                break;
            case 6:
                Hide(true);
                numbers[5].SetActive(true);
                break;
        }

    }

    private void Hide(bool i)
    {
        numbers[0].SetActive(false);
        numbers[1].SetActive(false);
        numbers[2].SetActive(false);
        numbers[3].SetActive(false);
        numbers[4].SetActive(false);
        numbers[5].SetActive(false);
        buttons[0].SetActive(i);
        buttons[1].SetActive(i);
        buttons[2].SetActive(i);
        buttons[3].SetActive(i);
    }
}
