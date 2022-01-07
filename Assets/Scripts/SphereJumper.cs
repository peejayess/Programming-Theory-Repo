using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereJumper : BaseJumper
{
    protected override void Jump()
    {
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
