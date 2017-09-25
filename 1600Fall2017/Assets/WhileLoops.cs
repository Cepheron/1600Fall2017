using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {
    public string[] Planescape;

    public bool inArcadia;
    public bool inMountCelestia;
    public bool inBytopia;
    public bool inElysium;
    public bool inBeastlands;
    public bool inArborea;
    public bool inYsgard;
    public bool inLimbo;
    public bool inCarceri;
    public bool inGehenna;

    void Update()
    {
        StartCoroutine(PlayGame());
    }

        IEnumerator PlayGame()
        {
            while (inArcadia)
            {
                print("You are in Arcadia");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inMountCelestia)
            {
                print("You are in Mount Celestia");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inBytopia)
            {
                print("You are in Bytopia");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inElysium)
            {
                print("You are in Elysium");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inBeastlands)
            {
                print("You are in the Beastlands");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inArborea)
            {
                print("You are in Arborea");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inYsgard)
            {
                print("You are in Ysgard");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inLimbo)
            {
                print("You are in Limbo");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inCarceri)
            {
                print("You are in Carceri");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

            while (inGehenna)
            {
                print("You are in Gehenna");
                yield return new WaitForSeconds(0.1f);
            }
            print("You are nowhere");

        }
}