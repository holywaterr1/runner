using UnityEngine;

public class PlatformBroke : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D PlayerRb = collision.GetComponent<Rigidbody2D>();
            if (PlayerRb != null)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }

    }
}