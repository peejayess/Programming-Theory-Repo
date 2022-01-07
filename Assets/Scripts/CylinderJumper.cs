using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderJumper : BaseJumper
{
    protected override void Jump()
    {
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
        rb.AddForce(Vector3.forward * 5, ForceMode.Impulse);
    }
}