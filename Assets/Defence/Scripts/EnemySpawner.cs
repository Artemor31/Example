using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy Enemy;
    public float Delay;

    private float _timer;

    private void Start()
    {
        _timer = Delay;
    }

    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            _timer = Delay;

            var x = Random.Range(-14, 14);
            int variant = Random.Range(0, 2);
            float y;
            if (variant == 0)
            {
                y = 1;
            }
            else
            {
                y = 5;
            }

            Vector3 position = new Vector3(x, y, 30);
            var clone = Instantiate(Enemy, position, Quaternion.identity);
        }
    }
}
