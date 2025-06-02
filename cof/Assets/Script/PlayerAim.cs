/*using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public Joystick aimJoystick; // joystick derecho
    public Transform playerBody;

    void Update()
    {
        Vector3 aimDirection = new Vector3(aimJoystick.Horizontal, 0f, aimJoystick.Vertical);

        if (aimDirection.sqrMagnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(aimDirection, Vector3.up);
            playerBody.rotation = Quaternion.Slerp(playerBody.rotation, targetRotation, Time.deltaTime * 10f);
        }
    }
}
*/