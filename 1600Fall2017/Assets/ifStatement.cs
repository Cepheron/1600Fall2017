using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour
{

    public float num1;
    public float num2;
    public float value;
    public float divResult;

    public bool canPlay;
    public bool buttonClicked = false;
    public bool keyboardOn = false;

    public Text input;
    private string password = "G@m3Pl@y";
    // Use this for initialization
    void Update()
    {
        if (num1 + num2 == value)
        {
            print(value);
        }
        if (canPlay)
        {
            print("Play");
        }
        else
        {
            print("Can't play");
        }
        if(input.text == password)
        {
            print("You know the password");
        }
        else
        {
            print("You don't know the password");
        }
        if (buttonClicked)
        {
            print("You pressed the button!");
        }
        else
        {
            print("You couldn't even do something simple");
        }
        if(keyboardOn)
        {
            print("it's working");
        }
        else
        {
            print("It's not working");
        }
        if (num1 != 0 && num2 != 0)
        {
            divResult = num1 / num2;
        }
        else
        {
            print("Can't divide by 0");
        }
    }
}
