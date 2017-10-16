using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {

    int numPlanes = 10;
    int numCats = 10;
    int numDogs = 10;
    int numEnemies = 10;
    int numFruits = 10;
    int numVegetables = 10;
    int numCars = 10;
    int numStates = 10;
    int numCities = 10;
    int numSongs = 10;




	void Start ()
    {
        for (int a = 0; a < numPlanes; a++)
        {
            print("Plane number: " + a);
        }
        for (int b = 0; b < numCats; b++)
        {
            print("This is cat " + b);
        }
        for (int c = 0; c < numDogs; c++)
        {
            print("This is dog " + c);
        }
        for (int d = 0; d < numEnemies; d++)
        {
            print("Creating enemy number: " + d);
        }
        for (int e = 0; e < numFruits; e++)
        {
            print("This fruit is number " + e);
        }
        for (int x = 0; x < numVegetables; x++)
        {
            print("This vegetable is number " + x);
        }
        for (int x = 0; x < numCars; x++)
        {
            print("Finding car " + x);
        }
        for (int x = 0; x < numStates; x++)
        {
            print("Adding state " + x);
        }
        for (int x = 0; x < numCities; x++)
        {
            print("Making city number " + x);
        }
        for (int x = 0; x < numSongs; x++)
        {
            print("Playing song number " + x);
        }

    }
	
}
