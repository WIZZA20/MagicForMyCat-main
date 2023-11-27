using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongoestadoliquido : MonoBehaviour
{
    public float speed;

    public bool esderecha;

    public float contadort;

    public float tiempoparacambiar = 4f;
    // Start is called before the first frame update
    void Start()
    {
        contadort = tiempoparacambiar;

    }

    // Update is called once per frame
    void Update()
    {
        if(esderecha == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(-2, 2, 2);
        }

        if (esderecha == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.localScale = new Vector3(2, 2, 2);
        }

        contadort -= Time.deltaTime;


        if(contadort <= 0)
        {
            contadort = tiempoparacambiar;
            esderecha = !esderecha;
        }

    }
}
