using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpStr;
    private Rigidbody2D rb2d;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpStr));
	}
        /*if (!Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJump", false);
	}*/
        if (Input.GetKeyDown(KeyCode.B))
        {
	    animator.SetBool("isBorn", true);
/*	    Debug.Log(gameObject.transform.position.y + " : " + 0.0f);	 */
        
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
	    animator.SetBool("isRun", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(30,0));
        if (!Input.GetKeyDown(KeyCode.D))
        {
	    animator.SetBool("isRun", false);
        }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.gameObject.tag == "ground")
        animator.SetBool("isGround", false);
    }
}
