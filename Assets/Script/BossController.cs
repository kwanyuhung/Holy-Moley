using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    //public Camera cam;
    //private Animator ani;
    //public SoundSFX soundEffect;
    //bool isWalking = false;
    Vector2 movement;
    //Vector2 mousePositionVector;

    //public GameObject seeds;
    public GameObject seed1UI;
    public GameObject seed2UI;
    public GameObject seed3UI;

    public GameObject totalSeedUI1;
    public GameObject totalSeedUI2;
    public GameObject totalSeedUI3;

    public Transform seed1Position;
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
        movement.x = Input.GetAxisRaw("BossHorizontal");
        movement.y = Input.GetAxisRaw("BossVertical");
        //Debug.Log(movement.x);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Seed1")
        {
            collision.gameObject.transform.position = seed1Position.position;
            seed1UI.gameObject.SetActive(true);
            totalSeedUI1.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Seed2")
        {
            collision.gameObject.SetActive(false);
            seed2UI.gameObject.SetActive(true);
            totalSeedUI2.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Seed3")
        {
            collision.gameObject.SetActive(false);
            seed3UI.gameObject.SetActive(true);
            totalSeedUI3.gameObject.SetActive(false);
        }
    }
}
