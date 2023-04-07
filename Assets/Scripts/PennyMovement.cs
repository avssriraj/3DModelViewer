using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PennyMovement : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float t;
    public float speed;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 f = target.position - transform.position;
        f = f.normalized;
        f = f * force;
        rb.AddForce(f);
        



    }
}
