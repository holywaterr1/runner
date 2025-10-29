using UnityEngine;
using static PlayerMovement;

public class PlatformCloud : MonoBehaviour
{
    public float CloudSpeed = 10f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D PlayerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Rigidbody2D PlatformCloudRb = gameObject.GetComponent<Rigidbody2D>();
            if (PlayerRb != null)
            {
                GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * CloudSpeed;
                player.Jump();

            }
        }
    }
}
