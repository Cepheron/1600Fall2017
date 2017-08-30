using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {
    public override void Start()
    {
        base.Start();
        Facebook();
        //The human class has facebook as an action it is doing
    }
    void Facebook ()
    {
        print(this.name + "Facebooks");
    }

}
