using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen = false;
    public float openAngle = 90f;
    public float openSpeed = 2f;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

        // Æ½»¬Ðý×ª
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            isOpen ? openRotation : closedRotation,
            Time.deltaTime * openSpeed
        );
    }
}
