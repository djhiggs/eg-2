using UnityEngine;
using System.Collections;

public class NewMovementScript : MonoBehaviour
{
    private Rigidbody myRigidBody;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

    private bool jump;
    private float jumpCount;
    private bool inAir;

    [SerializeField]
    private float jumpForce;

    //private bool pushPullTrigger;

    private GameObject player;
    private GameObject pushPullDetection;
    private GameObject crate;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("Player");
        pushPullDetection = GameObject.FindWithTag("PushPullDetection");
        crate = GameObject.FindGameObjectWithTag("Crate");
        facingRight = true;
        myRigidBody = GetComponent<Rigidbody>();
        //pushPullTrigger = false;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float zhorizontal = Input.GetAxis("zHorizontal");

        HandleMovement(zhorizontal);

        Flip(zhorizontal);

      
	}

    //private void OnTriggerStay(Collider PushPullTriggerDetection)
    //{
     //   Debug.Log("Its in the Crate");
      //  pushPullTrigger = true;
  //  }

    // Handles character movement
    private void HandleMovement(float zhorizontal)
    {
        //left right movement
        myRigidBody.velocity = new Vector2(zhorizontal * movementSpeed, myRigidBody.velocity.y);

        //jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            if (jump == true && jumpCount == 0)
            {
                myRigidBody.AddForce(new Vector2(0, jumpForce));
                jumpCount = 1;
                //inAir = true;
            }
            jump = false;
            if (myRigidBody.velocity.y == 0)
            {
                jumpCount = 0;
                //inAir = false;
            }
        }
     
        //pulling-pushing
        //if (Input.GetKeyDown(KeyCode.E) && inAir == false && pushPullTrigger == true)
        //{
            //gameObject.transform.SetParent;
            //crate.transform.SetParent(player);
        //}
    }

    //Turns around character
    private void Flip(float zhorzontal)
    {
        if (zhorzontal >0 && !facingRight || zhorzontal <0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.z *= -1;
            transform.localScale = theScale;
        }
    }


}
