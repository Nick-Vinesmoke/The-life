using UnityEngine;

public class humanLIfe : MonoBehaviour
{
    public float time = 0f;
    public int age = 0;
    public int finalAge;
    public int helth = 0;
    public bool gov= false;
    [SerializeField] Transform trans;

    private void Start()
    {
        finalAge = Random.Range(70, 101);
        trans.localScale = new Vector2(0.4f, 0.4f);
        helth = 10;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (age <= finalAge && time >= 10)
        {
            age++;
            gov = false;
            time = 0;
            if(age == finalAge)
            {
                Die();
            }
            
        }
        if (helth <= 0)
        {
            Die();
        }
        if (!gov)
        {
            GrowUp(age);
        }
        

    }


    void Die()
    {
        Destroy(gameObject);
    }

    void GrowUp(int age)
    {
        gov = true;

        if (age == 5)
        {
            trans.localScale = new Vector2(0.4f, 0.4f);
            helth += Random.Range(10, 21);
        }
        if (age == 10)
        {
            trans.localScale = new Vector2(0.6f, 0.6f);
            helth += Random.Range(10,21);
        }
        if (age == 14)
        {
            trans.localScale = new Vector2(0.8f, 0.8f);
            helth += Random.Range(10, 21);
        }
        if (age == 18)
        {
            trans.localScale = new Vector2(1f, 1f);
            helth += Random.Range(10, 21);
        }
        if (age == 24)
        {
            trans.localScale = new Vector2(1.1f, 1.1f);
            helth += Random.Range(10, 21);
        }
        if (age == 30)
        {
            trans.localScale = new Vector2(1f, 1f);
            helth -= Random.Range(5, 11);
        }
        if (age == 40)
        {
            helth -= Random.Range(5, 11);
        }
        if (age == 60)
        {
            helth -= Random.Range(5, 11);
        }
    }
}
