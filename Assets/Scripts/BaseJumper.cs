using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class BaseJumper : MonoBehaviour
{
    protected Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    protected abstract void Jump();

    public void HandleClick()
    {
        Jump();
    }
}
