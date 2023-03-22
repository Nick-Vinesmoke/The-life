using UnityEngine;
using Cinemachine;

public class cameraPivot : MonoBehaviour
{
    public Vector2 moveVector;
    public float speed = 6f;
    [SerializeField] Rigidbody2D rb;
    public KeyCode zoom = KeyCode.Equals;
    public KeyCode revert = KeyCode.Minus;
    [SerializeField] Camera cam;
    [SerializeField] CinemachineVirtualCamera virtualCamera;

    void FixedUpdate()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveVector.x * speed, moveVector.y * speed);
        if (Input.GetKey(zoom) && cam.orthographicSize < 60)
        {
            cam.orthographicSize = cam.orthographicSize + 0.1f;
            virtualCamera.m_Lens.OrthographicSize = virtualCamera.m_Lens.OrthographicSize + 0.1f;
            Debug.Log("+");
        }else if (Input.GetKey(revert) && cam.orthographicSize> 1)
        {
            cam.orthographicSize = cam.orthographicSize - 0.1f;
            virtualCamera.m_Lens.OrthographicSize = virtualCamera.m_Lens.OrthographicSize - 0.1f;
            Debug.Log("-");
        }
    }
}
