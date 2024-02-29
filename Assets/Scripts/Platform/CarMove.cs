using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float Speed;
    public float Rotation;

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, 0, ver / Speed);
        gameObject.transform.Translate(direction);

        Vector3 rotation = new Vector3(0, hor / Rotation, 0);
        gameObject.transform.Rotate(rotation);
    }
}
