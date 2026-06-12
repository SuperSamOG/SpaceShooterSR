using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data type (int, float, bool, string)
    //every variable has a name
    //optional value assigned

    [SerializeField]
    private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(HorizontalInput, VerticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        //if player position on the y is greater than 0
        //y position = 0
        //else if postion on the y is less than -3.8f
        //y pos = -3.8f

        if (transform.position.y > 7.6f)
        {
            transform.position = new Vector3(transform.position.x, -5.6f, 0);
        }
        else if (transform.position.y < -5.6f)
        {
            transform.position = new Vector3(transform.position.x, 7.6f, 0);
        }

        //if player position on the x is greater than 11
        //x pos = -11
        //else if player on the x is lesser than -11
        //x pos = 11

        if (transform.position.x > 11.3)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);

        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }
}
