using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    [Header("player")]
    static public Rigidbody2D player;
    public float speed = 2.5f, speedX, speedY;
    public bool sprint;
    public Animator frontMove;


    // Start is called before the first frame update
    void Start()
    {
        speed = 2.5f;
        player = GetComponent<Rigidbody2D>();
        sprint = false;
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        speedX = Input.GetAxisRaw("Horizontal") * speed;

        frontMove.SetFloat("walkY", speedY);

        speedY = Input.GetAxisRaw("Vertical") * speed;

        frontMove.SetFloat("walkX", speedX);

        player.velocity = new Vector2(speedX, speedY);

        //sprint & altering speed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
            speed = 4;
        }
        else
        {
            sprint = false;
            speed = 2.5f;
        }

        //flipping character
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.localScale = new Vector2(-4, 4);
        }
        else
        {
            gameObject.transform.localScale = new Vector2(4, 4);
        }

        
    }
}
        

