using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float sensitivity = 3;
    [Space]
    [SerializeField] private Transform headTransform;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        var input = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * sensitivity;
        var offset = input * 360 * Time.deltaTime;

        transform.Rotate(0f, offset.x, 0f);
        headTransform.Rotate(-offset.y, 0f, 0f);
    }
}
