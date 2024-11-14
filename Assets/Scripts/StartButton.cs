using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] string _name;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(_name);
        print("j");
    }
}
