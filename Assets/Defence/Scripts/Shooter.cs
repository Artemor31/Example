using UnityEngine;

namespace Defence.Scripts
{
    public class Shooter : MonoBehaviour
    {
        public Bullet Bullet;

        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                Bullet clone = Instantiate(Bullet, transform.position, transform.rotation);
            }
        }
    }
}