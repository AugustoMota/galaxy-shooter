using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
        var moveX= Input.GetAxis("Horizontal");
        var moveY= Input.GetAxis("Vertical"); 
        transform.Translate(speed * Vector3.right * Time.deltaTime * moveX);
        transform.Translate(speed * Vector3.up * Time.deltaTime * moveY);
    }
}
