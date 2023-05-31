using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStatus : MonoBehaviour
{
    public GameObject player;
    public int life;
    // Start is called before the first frame update
    void Start()
    {
      life = 1;  
    }

    // Update is called once per frame
    void Update()
    {
        lifeCounter();
    }

    private void lifeCounter()
    {
        if (life <= 0 )
        {
            Destroy(player, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Asteroid")
        {
            life --;
        }
    }
}
