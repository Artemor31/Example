using UnityEngine;
using UnityEngine.UI;

namespace DefenceWithHud.Scripts
{
    public class HUD : MonoBehaviour
    {
        public GameObject GameOverWindow;
        public Slider Slider;
        public Button RestartButton;

        private void OnEnable()
        {
            GameOverWindow.SetActive(false);
        }

        public void ShowGameOverWindow()
        {
            GameOverWindow.SetActive(true);
        }

        public void UpdateHealthBar(int health, int maxHealth)
        {
            Slider.SetValue(health, maxHealth);
        }

        public void IncrementScore()
        {

        }
    }
}
