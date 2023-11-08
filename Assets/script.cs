using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * speed, ForceMode.Impulse);
        }
    }
}
