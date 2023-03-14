using UnityEngine;

// From https://github.com/llamacademy/worldspace-health-bars/blob/main/Assets/Scripts/FaceCamera.cs
public class FaceCamera : MonoBehaviour
{
    public Camera Camera;

    private void Update()
    {
        transform.LookAt(Camera.transform, Vector3.up);
    }
}
