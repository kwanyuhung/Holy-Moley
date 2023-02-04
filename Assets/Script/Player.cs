using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    //public Camera cam;
    //private Animator ani;
    //public SoundSFX soundEffect;
    //bool isWalking = false;
    Vector2 movement;
    //Vector2 mousePositionVector;
    void Start()
    {
        //ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Debug.Log(movement);

        //do this one when we have sprite for the main character

        if (movement.x > 0 || movement.y > 0 || movement.x < 0 || movement.y < 0)
        {
            //ani.SetBool("isWalk", true);
           // soundEffect.footstep.Play();



        }
        else if (movement.x == 0 || movement.y == 0)
        {
            //ani.SetBool("isWalk", false);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Vector2 lookDirection = mousePositionVector - rb.position; //if we minus two vector, we will get the angle for look direction
        //float angle = Mathf.Atan2(lookDirection.y,lookDirection.x)* Mathf.Rad2Deg - 90f;
        //rb.rotation = angle; // set the rotation of the object equal to angle above 
        //Debug.Log("Rotate");
    }

    void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Debug.Log(movement.x);
        //mousePositionVector = cam.ScreenToWorldPoint(Input.mousePosition); //transfer the vector into wherever mousepoint to

        //flip the character
        if (movement.x >= 0.01f)
        {
            transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

        }


        else if (movement.x < -0.01f)
        {
            transform.localScale = new Vector3(-0.05f, 0.05f, 0.05f);

        }



    }
}
