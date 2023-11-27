using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camara2 : MonoBehaviour
{
    public GameObject cubo;
    private Vector3 offsetCamara;
    private Vector3 rotar;

    public float offSetY, offSetZ;
    private float x, y;
    public float Suavizado = 0f;
    public float sensibilidad = 1f;


    void Update()
    {
        // Muevo la posición de la cámara al cubo
        // ¿Quizás aalgo de offset le venga mejor?
        // No me acaba de convencer la cámara, ya que la rotación no va del todo bien...
        // ... pero para ser un prototipo va tirando
        this.transform.position = cubo.transform.position;
        

        // El problema es que la posición depende del centro de la esfera, así que la cámara, si quisierais poner offset, tmb debería depender de dicho centro.
        // sacar distancias y demás, no hace falta que lo hagáis.

        // Saco la rotación en el ejeX
        float mouseX = Input.GetAxis("Mouse X") * sensibilidad;

        // Saco la del eje Y
        float mouseY = -Input.GetAxis("Mouse Y") * sensibilidad;

        // Roto la cámara
        this.transform.Rotate(Vector3.up * mouseX + mouseY * Vector3.right);
        // Roto al cubo con la cámara!
        cubo.transform.Rotate(Vector3.up * mouseX + mouseY * Vector3.right);


        if(Input.GetKeyDown(KeyCode.Q)) this.transform.rotation = cubo.transform.rotation;
    }
}

