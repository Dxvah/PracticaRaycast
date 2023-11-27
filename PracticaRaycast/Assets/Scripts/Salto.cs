using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    public GameObject cube;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = -transform.up;
        
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
        
        isGrounded = false;
    }
    void OnDrawGizmos()
    {
        Vector3 origen = cube.transform.position;
        Vector3 direccion = -cube.transform.up;
        Gizmos.color = Color.red;
        Gizmos.DrawRay(origen, direccion * 2);
    }
}
