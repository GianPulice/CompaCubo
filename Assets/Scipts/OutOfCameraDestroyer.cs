using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfCameraDestoyer : MonoBehaviour
{
    public float destroyDistance = 10f; // Distancia fuera de la c�mara para destruir el objeto

    private void Update()
    {
        // Obtener la posici�n del objeto en la pantalla
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Verificar si el objeto est� fuera de la c�mara
        if (screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
        {
            Destroy(gameObject); // Destruir el objeto
        }

        // Tambi�n destruir si se aleja demasiado en el eje Z
        if (transform.position.z <= -destroyDistance)
        {
            Destroy(gameObject); // Destruir el objeto
        }
    }
}
