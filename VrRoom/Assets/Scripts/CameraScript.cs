using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float lookSpeed = 2f;
    public float moveSpeed = 10f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    private void Update()
    {
        // Camera rotation
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY -= Input.GetAxis("Mouse Y") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0f);

        // Camera movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = Input.GetKey(KeyCode.E) ? 1f : 0f;
        float moveDown = Input.GetKey(KeyCode.Q) ? 1f : 0f;

        Vector3 moveDirection = new Vector3(moveHorizontal, moveUp - moveDown, moveVertical);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
