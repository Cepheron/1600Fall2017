using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;	
	public float gravity = 9.81f;  
    public Vector3 moveVector3;
    public float jumpForce = 20;
	public CharacterController characterController;
    public static bool gameOver = false;
    public Text score;
    public Text win;
    private int count; 

    void Start ()
    {
        count = 0;
        SetScore();
        win.text = "";
    }

	void Update()
    {
        moveVector3.y -= gravity * Time.deltaTime;
        if (characterController.isGrounded && !gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveVector3.y = jumpForce * Time.deltaTime;
            }
            moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        characterController.Move(moveVector3);
    }	
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		GetComponent<Rigidbody>().velocity = movement * speed;	
	}

    void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.CompareTag("Pickup")) 
		{
			other.gameObject.SetActive(false);
			count = count + 10;
			SetScore();
		}
	}

    void SetScore() 
	{
		score.text = "Score: " + count.ToString ();
		if (count >= 12) 
		{
			win.text = "You win!";
		}
	}
}