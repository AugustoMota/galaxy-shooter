using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public float speed = 0.6f;
   

    void Start()
    {

    }

    void Update()
    {
        Posicaoinimigo();
    }


    private void Posicaoinimigo()
    {

        transform.Translate(speed * Vector3.down * Time.deltaTime);

        var newposition = transform.position;
        float randonmPoint = Random.value;

        if (transform.position.y < -6.5f)
        {

            newposition.y = 10.5f;
            newposition.x = Random.Range(-12f, 6f);
            transform.position = newposition;
        }

    }
}
