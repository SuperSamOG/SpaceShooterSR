using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _Speed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _Speed * Time.deltaTime);

        if(transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        
        }
    }
}
