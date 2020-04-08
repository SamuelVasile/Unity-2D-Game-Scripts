using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //movement variables
    public float maxSpeed;

    //jumping variables
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;
	
	void Start () {

        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

        facingRight = true;
	}

    private void Update()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
            myAnim.SetBool("isGrounded", grounded);
            myRB.AddForce(new Vector2(0, jumpHeight));
        }
    }

    // FixedUpdate is called once per frame
    void FixedUpdate () {
        //check if the character is grounded
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        myAnim.SetBool("isGrounded", grounded);

        myAnim.SetFloat("verticalSpeed", myRB.velocity.y);

        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("speed", Mathf.Abs(move));

        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

        if (move > 0 && !facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
	}

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public IEnumerator Knockback(float knockDur, float knockbackPow, Vector3 knockbackDir)
    {
        float timer = 0;

        while (knockDur > timer)
        {
            timer += Time.deltaTime;
            myRB.velocity = new Vector2(0, 0);
            myRB.AddForce(new Vector3(knockbackDir.x * -100, knockbackDir.y * knockbackPow, transform.position.z));

        }

        yield return 0;

    }
}
