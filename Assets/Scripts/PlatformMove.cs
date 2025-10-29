using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();
        player.Jump();
    }
    public float speed = 2f;
    public float distance = 5f;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float xoffset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector2(xoffset, 0);
    }
}
