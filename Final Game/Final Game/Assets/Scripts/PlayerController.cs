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
    public GameObject gameOverUI;

    void Start ()
    {
        // function that starts the instances if count and score
        count = 0;
        SetScore();
        win.text = "";
    }

	void Update()
    {
        // player horizontal movement and jump functions
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

    void OnTriggerEnter (Collider other) 
	{
        // checks if a certain object has the tag 'Pickup' and disables it when the player object passes over it as well as adding 20 to the score 
		if(other.gameObject.CompareTag("Pickup")) 
		{
			other.gameObject.SetActive(false);
			count = count + 20;
			SetScore();
		}
	}

    void SetScore() 
	{
        // function that checks for the score reaching 300 and ending the game with an extra message of 'You win!'
		score.text = "Score: " + count.ToString ();
		if (count >= 300) 
		{
			win.text = "You win!";
            gameOverUI.SetActive(true);
		}
	}
}