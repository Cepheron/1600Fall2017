using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour 
{	
	public GameObject playerExplosion;
	public GameObject gameOverUI;	
   
	void OnTriggerEnter (Collider other)	
	{		
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);			
		}		
		other.gameObject.SetActive(false);
		gameObject.SetActive(false);
		gameOverUI.SetActive(true);    
	}
}
