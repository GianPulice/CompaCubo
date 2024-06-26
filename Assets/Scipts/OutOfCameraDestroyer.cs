using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfCameraDestoyer : MonoBehaviour
{
    public float destroyDistance = 10f; // Distancia fuera de la cámara para destruir el objeto

    private void Update()
    {
        // Obtener la posición del objeto en la pantalla
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Verificar si el objeto está fuera de la cámara
        if (screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
        {
            Destroy(gameObject); // Destruir el objeto
        }

        // También destruir si se aleja demasiado en el eje Z
        if (transform.position.z <= -destroyDistance)
        {
            Destroy(gameObject); // Destruir el objeto
        }
    }
}
