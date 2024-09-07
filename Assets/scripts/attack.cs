using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class attack : MonoBehaviour
{

    public GameObject player;
    public GameObject blueFire;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //spawn blueFireball
        if (Input.GetKey(KeyCode.E))
        {
            //Instantiate(blueFire, controls.player.position, Quaternion.identity);
            animator.SetTrigger("blueFire");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            animator.ResetTrigger("blueFire");
        }
    }
     
    
}
