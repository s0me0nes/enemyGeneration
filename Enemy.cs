using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy _enemy;
    
    private void Start()
    {
        var createdEnemy = StartCoroutine(SpawnEnemy());
    }

    public bool GetRandomDirection()
    {
        int maxRandomValue = 10;
        int halfOfMaxRandomValue = 5;
        int random = Random.Range(0, maxRandomValue);

        return random < halfOfMaxRandomValue;
    }

    private IEnumerator SpawnEnemy()
    {
        var waitSeconds = new WaitForSeconds(2);

        while (true)
        {
            Transform randomPoint = _points[Random.Range(0, _points.Length)];
            var enemy = Instantiate(_enemy, new Vector2(randomPoint.position.x, randomPoint.position.y), Quaternion.identity);
            enemy.Init(GetRandomDirection());
            yield return waitSeconds;
        }
    }
}
