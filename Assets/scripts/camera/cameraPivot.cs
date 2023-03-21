using UnityEngine;

public class cameraPivot : MonoBehaviour
{
    public Vector2 moveVector;
    public float speed = 6f;
    [SerializeField] Rigidbody2D rb;

    void FixedUpdate()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveVector.x * speed, moveVector.y * speed);
    }
}
