using UnityEngine;

public class Projectil : MonoBehaviour
{
    public float lifeTime = 5f; // Tiempo m�ximo antes de autodestruirse (por seguridad)

    void Start()
    {
        // Destruye el proyectil autom�ticamente si no colisiona con nada
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Aqu� puedes filtrar por tag si quer�s que solo se destruya con ciertas cosas:
        if (collision.gameObject.CompareTag("Wall"))
         {
             Destroy(gameObject);
        }

        // Si no necesit�s filtro, se destruye al tocar cualquier objeto con collider
        Destroy(gameObject);
    }
}
