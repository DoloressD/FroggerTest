using UnityEngine;
using UnityEngine.SceneManagement;

public class Frogger : MonoBehaviour
{
    public Rigidbody2D rb;

    private bool keyPressed = false;

    void Update()
    {
        if (!keyPressed) //making real sure you cant speed the froggy up with two directional key presses
        {
            if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && transform.position.x < 8)
            {
                keyPressed = true;
                rb.MovePosition(rb.position + Vector2.right);
            }

            else if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && transform.position.x > -8)
            {
                keyPressed = true;
                rb.MovePosition(rb.position + Vector2.left);
            }
                
            else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                keyPressed = true;
                rb.MovePosition(rb.position + Vector2.up);
            }
                
            else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position.y > -4)
            {
                keyPressed = true;
                rb.MovePosition(rb.position + Vector2.down);
            }
                
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) ||
               Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) ||
               Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) ||
               Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
            {
                keyPressed = false;
            }
        }

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
