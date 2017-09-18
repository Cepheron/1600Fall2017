using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitchThing : MonoBehaviour
{

    public string[] weapons;

    public void MyWeaponSwitch(int i)
    {
        switch (weapons[i])
        {
            case "Shotgun":
                print("You are now using the shotgun");
                break;

            case "Frag Grenade":
                print("You are now using the frag grenade");
                break;

            case "Chainsaw":
                print("You are now using the chainsaw");
                break;

            case "Plasma Rifle":
                print("You are now using the plasma rifle");
                break;

            case "Heavy Assault Rifle":
                print("You are now using the heavy assault rifle");
                break;

            case "Rocket Launcher":
                print("You are now using the rocket launcher");
                break;

            case "Super Shotgun":
                print("You are now using the super shotgun");
                break;

            case "Hologram":
                print("You are now using the hologram");
                break;

            case "Gauss Rifle":
                print("You are now using the gauss rifle");
                break;

            case "BFG 9000":
                print("You are now using the BFG 9000");
                break;

            default:
                print("You are not using anything");
                break;
        }
    }
}
