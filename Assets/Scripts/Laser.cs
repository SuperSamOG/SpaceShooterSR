using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _Speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _Speed * Time.deltaTime);

        //if laser position is greater than 8 on the y
        //destroy the object

        if(transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        
        }
    }
}
