/*using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Joystick moveJoystick; // joystick izquierdo
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 moveInput = new Vector3(moveJoystick.Horizontal, 0f, moveJoystick.Vertical);
        if (moveInput.magnitude > 1f) moveInput.Normalize();

        Vector3 moveVelocity = moveInput * moveSpeed;
        rb.velocity = new Vector3(moveVelocity.x, rb.velocity.y, moveVelocity.z);
    }
}
*/
/*using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public SimpleJoystick joystick;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 input = joystick.InputDirection;
        Vector3 move = new Vector3(input.x, 0, input.y); // Z para vista cenital

        rb.MovePosition(transform.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
*/
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public SimpleJoystick joystick;

    void Update()
    {
        Vector2 input = joystick.InputDirection;
        Vector3 move = new Vector3(input.x, 0, input.y); // Movimiento en plano XZ (cenital)

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        // (Opcional) Girar al jugador en la dirección del movimiento
        if (move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720 * Time.deltaTime);
        }
    }
}
