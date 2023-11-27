using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(rayoCamara, out hit) && hit.collider.gameObject.tag == "Enemigo")
            {
                Destroy(hit.collider.gameObject, 1f);
            }
        }
    }
}
