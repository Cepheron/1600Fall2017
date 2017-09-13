using UnityEngine;
using UnityEngine.UI;

public class ifElse : MonoBehaviour
{
    public Text input;
    public bool canPlayGame = false;
    public string password = "G@m3Pl@y";
    // Use this for initialization
    void Update()
    {
        if (input.text == password)
        {
            print("You know the password");
        }
        else
        { 
            print("The password is incorrect");
        }
        if (canPlayGame)
        {
            print("Playing game");
        }
        else
        {
            print("Can't play yet, enter a correct password");
        }
    }
}
