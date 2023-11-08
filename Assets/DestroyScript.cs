using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    Rigidbody rigidbody;
    Collision collision;
    private Vector3 startPosition;
    private GameObject player;
    [SerializeField] private int yPosition = -10;

    
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        startPosition = GameObject.FindWithTag("Player").transform.position;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= yPosition)
        {
            player.gameObject.transform.position = startPosition;
        }
    
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Capsule")
        {
            player.gameObject.transform.position = startPosition;
        }

        if(collision.gameObject.tag == "Goal")
        {
            try {
           SceneManager.LoadScene("Berry(1)");
           } catch (System.Exception e) {
               Debug.Log("Couldnt load scene");
           }
        } 
    }

    
}
