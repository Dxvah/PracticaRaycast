using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = -transform.up;
        // Vecto3.down
        RaycastHit col;
        if (Physics.Raycast(origen, direccion, out col, 0.5f))
        {


            isGrounded = true;

        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        // TODO: Parametrizar esto!
        rb.AddForce(transform.up * 30);
        isGrounded = false;
    }
}
