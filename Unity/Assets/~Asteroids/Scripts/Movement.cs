using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Movement : MonoBehaviour
    {

        public float speed = 20f;// Use this for initialization
        public float rotationSpeed = 360f;

        private Rigidbody2D rigid;
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                // Rotate left
                transform.Rotate(Vector3.forward, rotationSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            { 
                // Rotate Right
                transform.Rotate(Vector3.forward, rotationSpeed);
            }
            if (Input.GetKey(KeyCode.W))
            {
                //up
                rigid.AddForce(transform.up * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                //down
                rigid.AddForce(transform.up * speed);
            }
        }
           


    }
}