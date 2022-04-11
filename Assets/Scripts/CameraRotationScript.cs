using UnityEngine;

public class CameraRotationScript : MonoBehaviour
{
    [SerializeField] private float axisX;
    [SerializeField] private float axisY;
    [SerializeField] private float rotationSensivity = 8f;

    [SerializeField] private Transform target;

    private void FixedUpdate()
    {
        axisY += Input.GetAxis("Mouse X") * rotationSensivity;
        axisX -= Input.GetAxis("Mouse Y") * rotationSensivity;

        Vector3 targetRotation = new Vector3(axisX, axisY);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * 2f + transform.up * 2f;
    }
}
