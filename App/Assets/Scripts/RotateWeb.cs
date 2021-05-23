using UnityEngine;

public class RotateWeb : MonoBehaviour {
    void Update()
    {
        transform.Rotate(new Vector3(0, 0.6f, 0));
    }
}