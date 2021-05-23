using UnityEngine;
using System.Collections;
 
public class RotateStatue : MonoBehaviour
{
 
    public int speed;
    public float friction;
    public float lerpSpeed;
    public float xDeg;
    Quaternion fromRotation;
    Quaternion toRotation;
 
    void Update ()
    {
        if (Input.GetMouseButton (0)) {
            Debug.Log((Mathf.Cos (xDeg/60)*10));
            xDeg -= Input.GetAxis ("Mouse X") * speed * friction;
            transform.eulerAngles = new Vector3(0,xDeg,0);
        }
    }
}