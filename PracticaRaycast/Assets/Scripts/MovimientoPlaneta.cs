using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MovimientoPlaneta : MonoBehaviour
{
    public float movX;
    public float movZ;
    Rigidbody rb;

    Vector3 gravedad;
    public Transform planeta;

    public Camera playerCamera; // Reference to the player camera


    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    
    void Update()
    {
        gravedad = -transform.up * 9.81f;
        Vector3 distnaciaPlaneta = (planeta.position - transform.position).normalized;

        GetComponent<Rigidbody>().AddForce(distnaciaPlaneta.normalized * 9.81f, ForceMode.Force);
    }
    private void FixedUpdate()
    {
        /*
                movX = Input.GetAxis("Horizontal");
                movZ = Input.GetAxis("Vertical");



                Vector3 movimiento = (movX * transform.right + movZ * transform.forward).normalized * 5;
                movimiento.y = rb.velocity.y;
                rb.velocity = movimiento;
        */

       
    }

    private void OnDrawGizmos()
    {
     /*   Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, (planeta.position - transform.position).normalized * 5);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.forward * 5);

        Gizmos.color = Color.grey;
        Gizmos.DrawRay(transform.position, Vector3.Cross(transform.forward, (planeta.position - transform.position).normalized)  * 5);*/
    }
}
