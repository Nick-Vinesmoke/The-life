/*
|==========================================================|
|████████╗██╗░░██╗███████╗░░░░░░██╗░░░░░██╗███████╗███████╗|
|╚══██╔══╝██║░░██║██╔════╝░░░░░░██║░░░░░██║██╔════╝██╔════╝|
|░░░██║░░░███████║█████╗░░█████╗██║░░░░░██║█████╗░░█████╗░░|
|░░░██║░░░██╔══██║██╔══╝░░╚════╝██║░░░░░██║██╔══╝░░██╔══╝░░|
|░░░██║░░░██║░░██║███████╗░░░░░░███████╗██║██║░░░░░███████╗|
|░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░░░░░░╚══════╝╚═╝╚═╝░░░░░╚══════╝|
|==========================================================|
|by: Nick_Vinesmoke                                        |
|https://github.com/Nick-Vinesmoke                         |
|https://github.com/Nick-Vinesmoke/Heat-RAT                |
|==========================================================|
 */

using UnityEngine;

public class humanMove : MonoBehaviour
{
    public int horizontal;
    public int vertical;
    public float speed;
    public float moveTime;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] humanLIfe life;
    private void FixedUpdate()
    {
        if (life.age < 5)
        {
            if (moveTime <= 0)
            {
                horizontal = Random.Range(-1, 2);
                vertical = Random.Range(-1, 2);
                moveTime = Random.Range(0, 11);
            }
            else if (moveTime > 0)
            {
                RandomMove(horizontal, vertical);
                moveTime -= Time.deltaTime;
            }
        }if (life.age < 10 && life.age >= 5)
        {

        }
        
    }
    void RandomMove(int h, int v)
    {
        rb.velocity = new Vector2(h * speed, v * speed);
    }
}
