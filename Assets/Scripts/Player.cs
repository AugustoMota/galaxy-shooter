using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// x 9.3080  -9.3080
// y 6.193606 -3.688
public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject tiro;
    public Transform offsetTiro;

    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        LimiteDeTela();

        if (Input.GetKeyDown(KeyCode.Space))
        {
           Atirar();
        }
    }

    private void LimiteDeTela()
    {
        if (transform.position.x > 9.0f)
        {
            var newposition = transform.position;
            newposition.x = 9.0f;
            transform.position = newposition;
        }

        if (transform.position.x < -9.0f)
        {
            var newposition = transform.position;
            newposition.x = -9.0f;
            transform.position = newposition;
        }

        if (transform.position.y > 6.0f)
        {
            var newposition = transform.position;
            newposition.y = 6.0f;
            transform.position = newposition;
        }

        if (transform.position.y < -4.0f)
        {
            var newposition = transform.position;
            newposition.y = -4.0f;
            transform.position = newposition;
        }
    }

    private void Movimentacao()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");
        transform.Translate(speed * Vector3.right * Time.deltaTime * moveX);
        transform.Translate(speed * Vector3.up * Time.deltaTime * moveY);
    }

    private void Atirar()
    {
        Instantiate(tiro,offsetTiro.position, Quaternion.identity);
    }
}
