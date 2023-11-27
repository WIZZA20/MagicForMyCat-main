using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientomanual : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed;
    [SerializeField] private float etime;

    private int lugaractual;
    private bool esperando;
   
    void Update()
    {
        if(transform.position != waypoints[lugaractual].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[lugaractual].position, speed * Time.deltaTime);
        }
        else if(!esperando)
        {
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        esperando = true;
        yield return new WaitForSeconds(etime);
        lugaractual++;
        if(lugaractual == waypoints.Length)
        {
            lugaractual = 0;
        }
        esperando = false;

        flip();
    }
    private void flip()
    {
        if (transform.position.x > waypoints[lugaractual].position.x)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }

}
