using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodys : MonoBehaviour
{
    public List<Collider> colliders = new List<Collider>();

    public object AddForce { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        foreach (Collider col in colliders)
        {
            col.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
