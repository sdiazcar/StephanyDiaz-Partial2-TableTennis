using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.up*speed);

        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.down * speed);

        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * speed);

        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * speed);{

        }

    }

}
