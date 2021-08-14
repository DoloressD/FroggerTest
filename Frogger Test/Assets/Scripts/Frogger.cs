using UnityEngine;
using UnityEngine.SceneManagement;

public class Frogger : MonoBehaviour
{
    public Rigidbody2D rb;

    private bool isHAxisInUse = false;
    private bool isVAxisInUse = false;

    void Update()
    {
        //rb.MovePosition(rb.position + new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))); i need the bounds
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        if (horizontalMove != 0)
        {
            if (!isHAxisInUse)
            {
                switch (horizontalMove)
                {
                    case 1:
                        if (transform.position.x < 8)
                        {
                            rb.MovePosition(rb.position + Vector2.right);
                            isHAxisInUse = true;
                        }
                        break;

                    case -1:
                        if (transform.position.x > -8)
                        {
                            rb.MovePosition(rb.position + Vector2.left);
                            isHAxisInUse = true;
                        }
                        break;
                }
            }
        }
            
        else
        isHAxisInUse = false;

        if (verticalMove != 0)
        {
            if (!isVAxisInUse)
            {

                switch (verticalMove)
                {
                    case 1:
                        rb.MovePosition(rb.position + Vector2.up);
                        isVAxisInUse = true;
                        break;

                    case -1:
                        if (transform.position.y > -4)
                        {
                            rb.MovePosition(rb.position + Vector2.down);
                            isVAxisInUse = true;
                        }
                        break;
                }
            }
        }
        else
        isVAxisInUse = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            Debug.Log("Splat");
            Stats.Deaths += 1;
            SceneManager.LoadScene(0);
        }
    }
}
