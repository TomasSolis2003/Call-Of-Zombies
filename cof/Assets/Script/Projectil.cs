using UnityEngine;

public class Projectil : MonoBehaviour
{
    public float lifeTime = 5f; // Tiempo máximo antes de autodestruirse (por seguridad)

    void Start()
    {
        // Destruye el proyectil automáticamente si no colisiona con nada
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Aquí puedes filtrar por tag si querés que solo se destruya con ciertas cosas:
        if (collision.gameObject.CompareTag("Wall"))
         {
             Destroy(gameObject);
        }

        // Si no necesitás filtro, se destruye al tocar cualquier objeto con collider
        Destroy(gameObject);
    }
}
