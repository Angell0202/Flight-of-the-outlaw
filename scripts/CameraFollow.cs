using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player's transform
    public Vector3 positionOffset = new Vector3(0, 5, -10); // The position offset from the player
    public Vector3 rotationOffset = new Vector3(10, 0, 0); // The rotation offset
    public float smoothSpeed = 0.125f; // The smoothing speed for the camera movement

    private void LateUpdate()
    {
        if (target == null) return;

        // Calculate the desired position with fixed x and y offsets, and the z-axis follows the player
        Vector3 desiredPosition = new Vector3(positionOffset.x, positionOffset.y, target.position.z + positionOffset.z);

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Apply the rotation offset
        Quaternion desiredRotation = Quaternion.Euler(rotationOffset);
        transform.rotation = desiredRotation;
    }
}
