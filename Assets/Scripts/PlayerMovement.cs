using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;

    [Header("Components")]

    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private bool _lookRight;
    
    private void Move()
    {
        _rigidbody.linearVelocity = new Vector2(Input.acceleration.x * _moveSpeed, _rigidbody.linearVelocity.y);

        CheckFlip();
    }

    public void Jump()
    {
        _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jumpForce);
    }

    private void CheckFlip()
    {  
       if(Input.acceleration.x > 0 && !_lookRight)
        {
            Flip();
        }
        else if (Input.acceleration.x < 0 && _lookRight)
        {
            Flip();
        }
        
    }


    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        _lookRight = !_lookRight;
    }
    public class Player : MonoBehaviour
    { }
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * _moveSpeed, rb.linearVelocity.y);

        if (rb.linearVelocity.x < 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        if (rb.linearVelocity.x > 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

    }
}
