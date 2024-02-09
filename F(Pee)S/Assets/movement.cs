using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
    }
}
