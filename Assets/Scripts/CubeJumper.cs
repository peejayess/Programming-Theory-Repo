using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumper : BaseJumper
{
    private bool rotate;
    
    protected override void Jump()
    {
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
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
