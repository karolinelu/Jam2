using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startingPosition;
    public float Speed;
    private float _timer;
    private Vector3 _cur_dir;
    void Start()
    {
        startingPosition = transform.position;
        _timer = 0;
        _cur_dir = new Vector3(UnityEngine.Random.Range(-1f, 1f),
                               0,
                               UnityEngine.Random.Range(-1f, 1f)).normalized;
        Speed = 1.5f;
    }




    private Vector3 GetRoamingPosition() 
    {
        Vector3 rd_dir = new Vector3(UnityEngine.Random.Range(-1f, 1f), 
                                    UnityEngine.Random.Range(-1f, 1f)).normalized;
        return startingPosition + rd_dir * Random.Range(3f, 6f);
    }


    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 3.0f)
        {
            _timer -= 3.0f;
            _cur_dir = new Vector3(UnityEngine.Random.Range(-1f, 1f),
                               0,
                               UnityEngine.Random.Range(-1f, 1f)).normalized;
        }

        transform.position += _cur_dir * Speed * Time.deltaTime;

    }
}
