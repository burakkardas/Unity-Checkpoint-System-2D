using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private Transform _movePoints;
    private int _randomPos;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _minX, _maxX, _minY, _maxY;
    [SerializeField] private float _time;
    private float _currentTime;
         
    void Start()
    {
        _movePoints.position = new Vector2(
            Random.Range(_minX, _maxX),
            Random.Range(_minY, _maxY)
        );
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            _movePoints.position,
            _moveSpeed * Time.deltaTime
        );

        if(Vector2.Distance(transform.position, _movePoints.position) < 0.2f) {
            if(_currentTime <= 0) {
                _movePoints.position = new Vector2(
                    Random.Range(_minX, _maxX),
                    Random.Range(_minY, _maxY)
                );
                _currentTime = _time;
            }
            else {
                _currentTime -= Time.deltaTime;
            }
        }
    }
}
