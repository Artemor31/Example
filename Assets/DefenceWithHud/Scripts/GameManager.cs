using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefenceWithHud.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public HUD Hud;
        public int Health;
        public Border Border;
        public EnemySpawner Spawner;

        private int _currentHealth;

        private void OnEnable()
        {
            Border.OnEnemyEnter += OnEnemyEnter;
            // Spawner.OnEnemyDies += OnEnemyDies;

            _currentHealth = Health;

            Hud.UpdateHealthBar(_currentHealth, Health);
            Hud.RestartButton.onClick.AddListener(RestartGame);
        }

        private void OnDisable()
        {
            Border.OnEnemyEnter -= OnEnemyEnter;
            Hud.RestartButton.onClick.RemoveListener(RestartGame);
        }

        public void RestartGame()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }

        private void OnEnemyEnter()
        {
            _currentHealth--;
            Hud.UpdateHealthBar(_currentHealth, Health);

            if (_currentHealth == 0)
            {
                Hud.ShowGameOverWindow();
                Time.timeScale = 0;
            }
        }

        private void OnEnemyDies()
        {
            Hud.IncrementScore();
        }
    }
}
