using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class wormMovement : MonoBehaviour
{
    public GameObject worm;
    public Transform wormTarget;
    float distance;
    void Start()
    {
        wormTarget = GameObject.FindGameObjectWithTag("cave").GetComponent<Transform>();
    }

    void Update()
    {
        worm.transform.position = Vector2.MoveTowards(transform.position, wormTarget.position, 3 * Time.deltaTime);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            {
            Destroy(worm);
            }
    }
}
