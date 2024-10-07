using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRate : MonoBehaviour
{

    public double timer = 0;

    private void FixedUpdate()
    {
        timer = timer + 1;
        if (tag == "goldcave" && timer == 120)
        {
            Instantiate(goldWorm, gameObject.transform.position, Quaternion.identity);
        }

        else if (tag == "greencave" && timer == 60)
        {
            Instantiate(greenWorm, gameObject.transform.position, Quaternion.identity);
        }

        else if (tag == "browncave" && timer == 30)
        {
            Instantiate(brownWorm, gameObject.transform.position, Quaternion.identity);
        }

        if(timer==121)
        {
            timer = 0;
        }

    }
    //public int spawnrate = 2;
    public GameObject brownWorm;
    public GameObject greenWorm;
    public GameObject goldWorm;
    //public bool spawning = true;

    //    private void spawn()
    //    {
    //        StartCoroutine(spawnTime());
    //    }

    //    private IEnumerator spawnTime()
    //    {
    //     //int spawnrate = Random.Range(0, 5);
    //     WaitForSeconds time = new WaitForSeconds(spawnrate);
    //        while (spawning)
    //        {
    //            yield return time;
    //            int rand = Random.Range(0, Worms.Length);
    //            GameObject randWorm = Worms[rand];

    //        Instantiate(randWorm, transform.position, Quaternion.identity);
    //        }
    //    }
}

