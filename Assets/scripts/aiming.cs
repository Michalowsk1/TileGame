using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiming : MonoBehaviour
{
    //[SerializeField] NavMeshAgent fireball;
    [SerializeField] Transform enemy;
    public float distance;
    public Rigidbody2D fireball;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        fireball = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    
    {
        distance = Vector2.Distance(enemy.transform.position, fireball.transform.position);
        if (distance < 6 && Input.GetKey(KeyCode.Space))
        {
            //transform.position = Vector2.MoveTowards(fireball.transform.position, enemy.transform.position, 0.01f);
            fireball.AddForce(transform.right * 5);
        }
        else
        {
            fireball.transform.position = spawn.position;
        }
        
    }
}

