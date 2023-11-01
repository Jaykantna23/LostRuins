using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = .125f;
    public Vector3 offset;
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 desiredPos = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
