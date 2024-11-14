using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void NextScene(string s)
    {
        SceneManager.LoadScene(s);
    }
}
