using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool _isRightMoving;
    private float _speed = 2;

    private void Start()
    {
        Destroy(gameObject, 7f);
    }

    private void Update()
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

    public void Init(bool isRightMoving)
    {
        _isRightMoving = isRightMoving;
    }
}
