using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{

    Rigidbody2D myRB;
    SpriteRenderer myRenderer;
    Animator myAnim;

    killSounds sounds;

    bool facingRight = true;  //cho nhân vật hướng mặt về bên phải

    //move
    public float maxSpeed;

    //jump
    private BoxCollider2D boxCollider2d;

    [SerializeField] private LayerMask platformLayerMask = 0;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myRenderer = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
        boxCollider2d = GetComponent<BoxCollider2D>();

        sounds = GameObject.FindGameObjectWithTag("sound").GetComponent<killSounds>();
    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal");

        if (move > 0 && !facingRight)
        {
            Flip();
            myAnim.SetBool("run", true);

        }

        else if (move < 0 && facingRight)
        {
            Flip();
            myAnim.SetBool("run", true);

        }
        else
        {
            myAnim.SetBool("run", false);

        }



        // ngồi xuống (cho zoom lại nhân vật)
        if (IsGrounded() && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.localScale = new Vector3(1.2f, 0.9f, 1.2f);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {

            gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }


        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);


        // nhân vật nhảy
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 15f;
            myRB.velocity = Vector2.up * jumpVelocity;
            myAnim.SetBool("jump", true);

            sounds.Playsound("soundMarioJump");

        }
        else
        {
            myAnim.SetBool("jump", false);
        }

    }


    // hàm này đảm bảo chúng ta đang đi đúng hướng
    void Flip()
    {
        facingRight = !facingRight;
        myRenderer.flipX = !myRenderer.flipX;
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        // Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

}
