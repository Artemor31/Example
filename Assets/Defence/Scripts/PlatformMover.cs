using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float Speed;
    public float JumpPower;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * Speed);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
        }
    }
}
