using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
    public override void Start() {
        base.Start();
        LiveBirth();
        //this is a mammal class that is attached to the animal class
    }
    void LiveBirth ()
    {
        print(this.name + "Live Births");
    }

}
