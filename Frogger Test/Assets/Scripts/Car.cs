using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    private float moveSpeed = 1f;

    private float minSpeed;
    private float maxSpeed;


    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            minSpeed = 3f;
            maxSpeed = 5f;
        }
        else if(SceneManager.GetActiveScene().name == "Level2")
        {
            minSpeed = 8f;
            maxSpeed = 14f;
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            minSpeed = 20f;
            maxSpeed = 25f;
        }

        moveSpeed = Random.Range(minSpeed, maxSpeed);

        Destroy(gameObject, 8f);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y); //Car to run where it faces, so that I can have either it coming from the left or right easily
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * moveSpeed);
    }
}
