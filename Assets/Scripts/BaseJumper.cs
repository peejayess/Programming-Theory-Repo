using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE - Base Class
[RequireComponent(typeof(Rigidbody))]
public abstract class BaseJumper : MonoBehaviour
{
    protected Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // POLYMORPHISM - Abstract Method
    protected abstract void Jump();

    public void HandleClick()
    {
        // ABSTRACTION - Jump method is abstracted into base classes
        Jump();
    }
}
