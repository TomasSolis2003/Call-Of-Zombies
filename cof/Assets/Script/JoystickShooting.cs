using UnityEngine;

public class JoystickShooting : MonoBehaviour
{
    public VariableJoystick rightJoystick; // Joystick derecho para apuntar
    public GameObject projectilePrefab;    // Prefab del proyectil
    public Transform firePoint;            // Punto de disparo (puede ser la mano del jugador, por ejemplo)
    public float projectileSpeed = 10f;    // Velocidad del proyectil
    public float fireRate = 0.3f;          // Tiempo entre disparos

    private float nextFireTime = 0f;

    void Update()
    {
        Vector2 input = new Vector2(rightJoystick.Horizontal, rightJoystick.Vertical);

        if (input.magnitude > 0.2f && Time.time >= nextFireTime) // Solo dispara si el joystick está presionado
        {
            nextFireTime = Time.time + fireRate;

            // Calcula dirección y dispara
            Vector3 shootDir = new Vector3(input.x, 0f, input.y).normalized;
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = shootDir * projectileSpeed;
        }
    }
}
