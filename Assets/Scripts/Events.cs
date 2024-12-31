using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("EasyRun");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
