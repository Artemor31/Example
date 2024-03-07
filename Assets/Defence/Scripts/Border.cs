using UnityEngine;

namespace Defence.Scripts
{
    public class Border : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);   

            if (other.GetComponent<Enemy>() != null)
            {
            }
        }
    }
}
