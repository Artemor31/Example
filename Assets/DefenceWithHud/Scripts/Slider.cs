using UnityEngine;
using UnityEngine.UI;

namespace DefenceWithHud.Scripts
{
    public class Slider : MonoBehaviour
    {
        public Image ValueImage;

        public void SetValue(float current, float max)
        {
            float value = current / max;
            ValueImage.fillAmount = value;
        }
    }
}
