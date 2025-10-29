using UnityEngine;

public class PlatformBoost : MonoBehaviour
{
    public float JumpBoost = 15f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>();

            if (playerRb != null)

            {
                playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, 0);
                playerRb.AddForce(Vector2.up * JumpBoost, ForceMode2D.Impulse);
            }
        }
    }
}
