using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

	bool isRed = true;
	bool isBlue = true;
	public void Main(string[] args) 
	{
		if (isRed && isBlue) 
		{
			print ("This is true");
		}
		if (isRed || isBlue) 
		{
			print("This is true");
		}
		if (!(isRed && isBlue)) 
		{
			print ("This is false");
		}

	bool myCat = false;
	bool myDog = true;

		if (myCat && myDog)
		{
			print ("This is true");
		}	
		if (myCat || myDog) 
		{
			print ("This is false");
		}
		if (!(myCat && myDog)) 
		{
			print ("This is false");
		}
	bool a = false;
	bool b = false;

		if (a && b) 
		{
			print ("This is false");
		}
		if (a || b) 
		{
			print ("This is false");
		}
		if (!(a && b)) {
			print ("This is true");
		}
		if (!(a || b)) 
		{
			print ("This is true");
		}	
	}
}
