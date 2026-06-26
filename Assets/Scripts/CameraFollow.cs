using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 20, 0);

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }
}