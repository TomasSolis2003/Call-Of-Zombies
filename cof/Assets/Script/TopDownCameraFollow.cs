using UnityEngine;

public class TopDownCameraFollow : MonoBehaviour
{
    public Transform player;           // El objeto jugador a seguir
    public Vector3 offset = new Vector3(0, 10f, 0); // Altura y distancia desde arriba
    public float smoothSpeed = 5f;     // Velocidad de seguimiento

    void LateUpdate()
    {
        if (player == null)
            return;

        // Posici�n deseada con el offset aplicado
        Vector3 desiredPosition = player.position + offset;

        // Interpolaci�n suave entre la posici�n actual y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Hacer que la c�mara mire hacia abajo
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
