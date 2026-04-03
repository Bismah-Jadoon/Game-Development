using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private BoxCollider2D coll;
    private float dirX = 0f;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private LayerMask jumpableGround;

    private enum MovementState {idle, running, jumping, falling};
    
    [SerializeField] private AudioSource jumpSoundEffect;
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       anim = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
       coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(dirX * moveSpeed, rb.linearVelocity.y);
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
           jumpSoundEffect.Play();
           rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

         UpdateAnimationState();     
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if(dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.linearVelocity.y > 0.1f)
        {
            state = MovementState.jumping;
        }
        else if(rb.linearVelocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);


    }

    private bool isGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
