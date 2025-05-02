using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        bool isMoving = moveInput.sqrMagnitude > 0.1f;

        animator.SetFloat("MoveHorizontal", moveInput.x);
        animator.SetFloat("MoveVertical", moveInput.y);
        animator.SetBool("IsMoving", isMoving);

        if (isMoving)
        {
            animator.SetFloat("LastMoveHorizontal", moveInput.x);
            animator.SetFloat("LastMoveVertical", moveInput.y);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput.normalized * speed * Time.fixedDeltaTime);
    }
}
