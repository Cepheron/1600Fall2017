using UnityEngine;
using UnityEngine.UI;

public class ifStatementEnhanced2 : MonoBehaviour
{
    // Private, public, etc. are access modifiers. These can be called anywhere
    private int num1;
    internal int num2;
    protected int value;
    public int num3;
    public int num4;
    public int result;

    public bool canPlay;
    public bool buttonClicked = true;
    public bool dumbApple;
    public bool keyboardOn = true;

    public Text input;
    private string password = "G@m3Pl@y";
    // Use this for initialization
    void Update()
    {
        // All these things are in the scope of the function. They can only be called within the fuction and no where else and you cannot make them public within the function.
        if (num1 + num2 == value)
        {
            print(value);
        }
        if (canPlay)
        {
            print("Play");
        }
        if(input.text == password)
        {
            print("You know the password");
        }
        if (buttonClicked == true)
        {
            print("You have clicked the button! Good job.");
        }
        else
        {
            print("You couldn't even do something simple!");
        }
        if (num3 * num4 == result)
        {
            print(result);
        }
        if (num1 % num4 == value)
        {
            print(value);
        }
        if (dumbApple)
        {
            print("Apple software is stupid");
        }
        if (num4 - num1 == value)
        {
            print(value);
        }
        if (num3 / num4 == result)
        {
            print(result);
        }
        if (keyboardOn == true)
        {
            print("Your keyboard is working");
        }
        else
        {
            print("Your keyboard is broken");
        }

    }
}
