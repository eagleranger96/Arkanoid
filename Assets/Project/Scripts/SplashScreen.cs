using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    float splashTimer = 3f;

    private void Update()
    {
        if(splashTimer <= 0f)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            splashTimer -= Time.deltaTime;
        }
    }
}
