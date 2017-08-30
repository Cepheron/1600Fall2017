using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal {

    public override void Start() {
        base.Start();
        Fly();
        //Bird is part of the animal class
    }
    void Fly() {
        print(this.name + "Flies");
        }
}
