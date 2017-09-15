using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators2 : MonoBehaviour
{

    public float num1;
    public float num2;
    public float num3;
    public float num4;
    public float addResult;
    public float subResult;
    public float multResult;
    public float divResult;
    public float remainderResult;
    void Update()
    {
        addResult = num1 + num2;
        subResult = num1 - num2;
        multResult = num1 * num2;
        if (num1 != 0 && num2 != 0)
        {
            divResult = num1 / num2;
        }
        else
        {
            print("Can't divide by 0");
        }
        remainderResult = num1 % num2;

        num4 = num1 + num2;
        num4 = num1*(num2 + num3);
        num4 = num1 - num2;
        num4 = num3 / (num1 - num2);
        num4 = num1 * num2;
        num4 = num2 % (num1 * num3);
        num4 = num1 / num2;
        num4 = (num1 + num2) / (num2 - num3);
        num4 = num2 % num3;
        num4 = num1 * (num1 - num2) * (num1 + num3);

    }   
    
}

