using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMiss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(3);
    }
}
