using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 7.75f, 0);

    }

    // Update is called once per frame
    void Update()
    {
     
        transform.Translate(Vector3.down  * _speed * Time.deltaTime);

        if(transform.position.y < -8F)
        {
            float randomX = Random.Range(-9.5f, 9.5f);
            transform.position = new Vector3(randomX, 7.75f, 0);
                
        }
    }
}
