using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform[] blocks;

    public static float score = 0f;

    bool flag = false;

    private void Start()
    {
        score = 0f;
    }

    void Update()
    {
        flag = true;
        foreach (Transform block in blocks)
        {
            if(block.childCount != 0)
            {
                flag = false;
                break;
            }
        }
        if(flag)
        {
            SceneManager.LoadScene(4);
        }
    }
}
