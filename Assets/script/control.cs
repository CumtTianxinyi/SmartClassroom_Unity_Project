using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    public float speed = 10f;
    public float sensitivity = 2f;

    private float rotationY = 0f;

    void Update()
    {
        // ÒÆ¶¯
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveY = 0;
        if (Input.GetKey(KeyCode.R)) moveY += speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.F)) moveY -= speed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, moveY, moveZ));

        // Ðý×ª
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -90, 90);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}