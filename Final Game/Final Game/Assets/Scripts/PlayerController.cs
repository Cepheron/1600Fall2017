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
<<<<<<< HEAD

=======
	
>>>>>>> master
    void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.CompareTag("Pickup")) 
		{
			other.gameObject.SetActive(false);
			count = count + 20;
			SetScore();
		}
	}

    void SetScore() 
	{
		score.text = "Score: " + count.ToString ();
		if (count >= 300) 
		{
			win.text = "You win!";
            gameOverUI.SetActive(true);
		}
	}
}