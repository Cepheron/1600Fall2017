using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour
{

    public int num1;
    public int num2;
    public int value;

    public bool canPlay;

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
        if(input.text == password)
        {
            print("You know the password");
        }
    }
}
