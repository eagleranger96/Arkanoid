using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 150.0f;

    private void FixedUpdate()
    {
        float hi = Input.GetAxisRaw("Horizontal");
        this.GetComponent<Rigidbody2D>().velocity = Vector2.right * hi * speed;
    }
}
