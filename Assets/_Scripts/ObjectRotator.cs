using System;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public bool isDragging;
    public float rotationSpeed;
    public Vector3 initPos;
    public Rigidbody rb;
    public Transform cam;

    public float minX;
    public float maxX;

    public float minY;
    public float maxY;
    
    public float minZ;
    public float maxZ;

    public void Start()
    {
        cam = Camera.main.transform;
    }

    private void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float y = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.down, x, Space.World);
        transform.Rotate(cam.right, y, Space.World);

        LimitRotation();
    }

    [ContextMenu("Get Rotation")]
    public void GetRotation()
    {
        Debug.Log(transform.localRotation.eulerAngles);
    }

    void LimitRotation()
    {
        Vector3 playerAngles = transform.rotation.eulerAngles;
        playerAngles.x = (playerAngles.x > 180) ? playerAngles.x - 360 : playerAngles.x;
        playerAngles.x = Mathf.Clamp(playerAngles.x, minX, maxX);

        playerAngles.y = (playerAngles.y > 359.9f) ? playerAngles.y - 360 : playerAngles.y;
        playerAngles.y = Mathf.Clamp(playerAngles.y, minY, maxY);
        
        playerAngles.z = (playerAngles.z > 180) ? playerAngles.z - 360 : playerAngles.z;
        playerAngles.z = Mathf.Clamp(playerAngles.z, minZ, maxZ);
        transform.rotation = Quaternion.Euler(playerAngles);
    }
}