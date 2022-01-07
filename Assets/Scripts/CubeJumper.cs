using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE - Derived Class
public class CubeJumper : BaseJumper
{
    private int force = 20;

    // ENCAPSULATION - Can override force if required
    public int Force
    {
        get => force;
        set => force = value;
    }


    private bool rotate;
    
    // POLYMORPHISM - Derived Method
    protected override void Jump()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        rotate = true;
    }

    private void Update()
    {
        if(rotate)
            rb.transform.Rotate(Vector3.up);
    }

    private void OnCollisionEnter(Collision collision)
    {
        rotate = false;
    }
}
