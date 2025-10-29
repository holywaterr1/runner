using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformSpike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D PlayerRb = collision.GetComponent<Rigidbody2D>();

            if (PlayerRb != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
