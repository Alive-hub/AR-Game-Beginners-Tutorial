using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePhysicsOnEvent : MonoBehaviour
{
    [SerializeField] private Rigidbody rb; 

    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += StartPhysicsOnButtonClicked;
        rb.isKinematic = true;
    }

    private void StartPhysicsOnButtonClicked()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnDestroy()
    {
        UIButtonHandler.OnUIStartButtonClicked -= StartPhysicsOnButtonClicked;
    }
}
