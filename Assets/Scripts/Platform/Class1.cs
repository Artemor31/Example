using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using UnityEngine;

namespace Assets
{
    public class PlaneScript : MonoBehaviour
    {
        public GameObject _sphere;
        private float _time;

        private void Update()
        {
            Debug.Log(_time);
            float hor = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            _time += Time.deltaTime;

            gameObject.transform.Rotate(new Vector3(vert / 5, 0, hor / 5));

            if (_sphere.transform.position.y < -6)
            {
                _sphere.transform.position = Vector3.zero;
                _time = 0;
            }
        }
    }
}
