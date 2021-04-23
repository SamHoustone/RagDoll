using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Character;
    public Transform camera;
    public Vector3 offset;
    public Rigidbody[] rb;

    public int number;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentsInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < rb.Length;i++)
            {
                rb[i].AddForce(transform.forward * number,ForceMode.Impulse);
                rb[i].mass = 1;
            }
        }

        camera.position = Character.position + offset;
    }
}

