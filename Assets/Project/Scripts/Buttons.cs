using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
	public void OnPlayClick()
    {
        SceneManager.LoadScene(2);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
