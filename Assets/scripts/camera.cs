using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform player;
    public Animator walkingDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);
    }
}
