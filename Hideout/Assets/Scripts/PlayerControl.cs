using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2.0f; //var for speed
    Rigidbody2D rb2D; //var for the Rigidbody2D

    // Start is called before the first frame update
    void Start()
    {
        //set rigidbody for this object
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // frame-based step for speed
        float step =  speed * Time.deltaTime;
        
        //todo: remove if no longer needed
        // old WASD controls
        /*
        if (Input.GetKey(KeyCode.W))
        {
            //transform.pos
            transform.Translate(0, step, 0);
            //rb2D.MovePosition(Vector2.up * step);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += Vector2.left * step;
            //rb2D.MovePosition(Vector2.left * step);
            transform.Translate(-step, 0, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += Vector2.down * step;
            //rb2D.MovePosition(Vector2.down * step);
            transform.Translate(0, -step, 0);


        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += Vector2.right * step;
            //rb2D.MovePosition(Vector2.right * step);
            transform.Translate(step, 0, 0);

        }
        */
        
        // new WASD controls
        if (Input.GetKey(KeyCode.W)) //if W is pressed
        {
            rb2D.AddForce(Vector2.up * speed); //apply to the up mult by the "force" var
        }
        if (Input.GetKey(KeyCode.S)) //if S is pressed
        {
            rb2D.AddForce(Vector2.down * speed); //apply to the up mult by the "force" var
        }
        if (Input.GetKey(KeyCode.A)) //if A is pressed
        {
            rb2D.AddForce(Vector2.left * speed); //apply to the up mult by the "force" var
        }
        if (Input.GetKey(KeyCode.D)) //if D is pressed
        {
            rb2D.AddForce(Vector2.right * speed); //apply to the up mult by the "force" var
        }
        
        
    }
}
