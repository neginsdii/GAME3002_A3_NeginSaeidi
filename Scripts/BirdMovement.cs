using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody body;
    public bool isGrounded = false;
    public static float WalkSpeed = 5.0f;
    public static float jumpSpeed = 7.0f;
    public int numJumps = 0;
    public Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        body.velocity = new Vector3(0, body.velocity.y, Input.GetAxis("Horizontal") * WalkSpeed);
        
        if (Input.GetAxis("Horizontal") > 0)
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, Mathf.Abs(transform.localScale.z));
        if (Input.GetAxis("Horizontal") < 0)
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, Mathf.Abs(transform.localScale.z) * -1);
        if (Input.GetButtonDown("Jump"))
		{
            if (numJumps<2)
            {
                if(numJumps==0)
                body.velocity = new Vector3(0, jumpSpeed, jumpSpeed-1);
                else
                  body.velocity = new Vector3(0, jumpSpeed-2, jumpSpeed-3);
                isGrounded = false;
                numJumps++;
            }

        }
    }

	private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "plane")
		{
            isGrounded = true;
            numJumps = 0;

        }

        if (other.gameObject.tag == "slope")
        {
            isGrounded = true;
            numJumps = 0;
        }

        if (other.gameObject.tag == "tent")
        {

            transform.position = spawnPos.position;

            isGrounded = false;
            numJumps = 0;
        }

    }
}
