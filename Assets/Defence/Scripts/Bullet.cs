using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
    }
}
