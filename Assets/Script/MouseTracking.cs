using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseTracking : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

   // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();

        Ray cameraRay = mainCamera.ScreenPointToRay(mousePos);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        Vector3 lookAtPosition;

        if (groundPlane.Raycast(cameraRay, out float rayLength))
        {
            lookAtPosition = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, lookAtPosition, Color.blue);

            lookAtPosition.y = transform.position.y;
            transform.LookAt(lookAtPosition);
        }
    }

    
}
