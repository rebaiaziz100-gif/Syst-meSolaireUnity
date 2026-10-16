using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float mouseSensitivity = 0.2f;

    float rotationX = 0f;
    float rotationY = 0f;

    void Update()
    {
        // Mouse look
        Vector2 mouse = Mouse.current.delta.ReadValue();

        rotationY += mouse.x * mouseSensitivity;
        rotationX -= mouse.y * mouseSensitivity;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);

        // WASD movement
        Vector3 movement = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            movement += Vector3.forward;

        if (Keyboard.current.sKey.isPressed)
            movement += Vector3.back;

        if (Keyboard.current.aKey.isPressed)
            movement += Vector3.left;

        if (Keyboard.current.dKey.isPressed)
            movement += Vector3.right;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}