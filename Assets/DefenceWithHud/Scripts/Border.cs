using System;
using UnityEngine;

namespace DefenceWithHud.Scripts
{
    public class Border : MonoBehaviour
    {
        public event Action OnEnemyEnter;

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);   

            if (other.GetComponent<Enemy>() != null)
            {
                OnEnemyEnter?.Invoke();
            }
        }
    }
}
