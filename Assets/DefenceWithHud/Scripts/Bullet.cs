using UnityEngine;

namespace DefenceWithHud.Scripts
{
    public class Bullet : MonoBehaviour
    {
        public float Speed;

        private void Update()
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * Speed));
        }
    }
}
