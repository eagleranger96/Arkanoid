using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score.text = "Score: " + GameController.score;
    }
}