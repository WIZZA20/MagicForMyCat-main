using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reboteboing : MonoBehaviour
{
    public float velocidad = 1f;

    public Transform Player;


void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.position.x, transform.position.y),velocidad * Time.deltaTime);
    }

}
