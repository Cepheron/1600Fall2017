using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {
    // This is the outside box. These can be called anywhere. Public and private are access modifiers
    private int health = 100;
    // These are also called fields. It is called a variable when in a function.

    public int score = 100;

    // This is in the "class" box. This one can also be called at any time
    void Start()
    // Anything inside of the start "box" can't be called anywhere else but inside that function. This is in scope
    {
        int newScore = 10;
        print(newScore);
    }

}

