using UnityEngine;

namespace Defence.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public float Speed;

        private void Update()
        {
            transform.Translate(Vector3.back * (Time.deltaTime * Speed));
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
