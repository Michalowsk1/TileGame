using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class controls : MonoBehaviour
{
    [Header("player")]
    static public Rigidbody2D player;
    public float speed = 2.5f, speedX, speedY;
    public bool sprint;
    public Animator frontMove;
    [SerializeField] public static int point;
    public AudioSource squish;


    // Start is called before the first frame update
    void Start()
    {
        speed = 2.5f;
        player = GetComponent<Rigidbody2D>();
        sprint = false;
        point = 0;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "brown")
        {
            point++;
            squish.Play();
        }

        else if (collision.gameObject.tag == "green")
        {
            point = point + 2;
            squish.Play();
        }

        else if (collision.gameObject.tag == "gold")
        {
            point = point + 3;
            squish.Play();
        }
    }
 
}
        

