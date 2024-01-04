
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    void LateUpdate()
    {
        // Camera follows the player with specified offset position
        if (playerTransform != null)
        {
            transform.position = new Vector3(playerTransform.position.x + offset.x, offset.y, offset.z);
        }
    }
}
