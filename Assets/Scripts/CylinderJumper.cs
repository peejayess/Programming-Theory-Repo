using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE - Derived Class
public class CylinderJumper : BaseJumper
{
    // POLYMORPHISM - Derived Method
    protected override void Jump()
    {
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
        rb.AddForce(Vector3.forward * 5, ForceMode.Impulse);
    }
}
