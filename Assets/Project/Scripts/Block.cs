using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(this.tag)
        {
            case "BlueBlock":
                GameController.score += 25;
                break;
            case "GreenBlock":
                GameController.score += 20;
                break;
            case "PinkBlock":
                GameController.score += 15;
                break;
            case "RedBlock":
                GameController.score += 10;
                break;
            case "YellowBlock":
                GameController.score += 5;
                break;
            default: break;
        }
        Destroy(this.gameObject);
    }
}
