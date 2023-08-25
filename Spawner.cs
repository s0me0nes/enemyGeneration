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

    public bool IsDirection()
    {
        int maxRandomValue = 10;
        int halfOfMaxRandomValue = 5;
        int random = Random.Range(0, maxRandomValue);

        return random < halfOfMaxRandomValue;
    }

    IEnumerator SpawnEnemy()
    {
        var waitSeconds = new WaitForSeconds(2);

        while (true)
        {
            Transform randomPoint = _points[Random.Range(0, _points.Length)];
            Instantiate(_enemy, new Vector2(randomPoint.position.x, randomPoint.position.y), Quaternion.identity);
            yield return waitSeconds;
        }
    }
}
