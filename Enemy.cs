using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Spawner _spawner;
    private bool _isRightMoving;
    private float _speed = 2;

    private void Start()
    {
        Destroy(gameObject, 7f);
        _spawner = FindObjectOfType<Spawner>();
        _isRightMoving = _spawner.IsDirection();
    }

    void Update()
    {
        if (_isRightMoving)
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else if (_isRightMoving == false)
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
        }
    }
}
