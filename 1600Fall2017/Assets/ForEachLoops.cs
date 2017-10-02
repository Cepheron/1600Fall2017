﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour {

    public string[] planescapePlanes = new string[10];

    private void Start()
    {
        planescapePlanes[0] = "Arcadia";
        planescapePlanes[1] = "Mount Celestia";
        planescapePlanes[2] = "Bytopia";
        planescapePlanes[3] = "Elysium";
        planescapePlanes[4] = "Beastlands";
        planescapePlanes[5] = "Arborea";
        planescapePlanes[6] = "Ysgard";
        planescapePlanes[7] = "Limbo";
        planescapePlanes[8] = "Carceri";
        planescapePlanes[9] = "Gehenna";

		//This loop will print out the names of the planes until it reaches the end.

		foreach (string planes in planescapePlanes) 
		{
			print(planes);
		}    
	
	}
}