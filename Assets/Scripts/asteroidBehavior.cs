using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidBehavior : MonoBehaviour
{
    public GameObject asteroid;
    [SerializeField]
    public GameObject miniAsteroids;
    private int size;
    [SerializeField]
    private int velocity;
    [SerializeField]
    private int life;
    [SerializeField]
    private int spawnerAsteroids;
    [SerializeField]
    private int xScale;

    // Start is called before the first frame update
    void Start()
    {   
        //sets size on a certain range
        xScale = Random.Range(3, 5);
        asteroid.transform.localScale = new Vector3(xScale, xScale, xScale);
        //set asteroid velocity between 1 to 7s
        velocity = Random.Range(1, 7);
        //spawns asteroids in a random rotation
        transform.Rotate(0, 0, Random.Range(0.0f , 360.0f));
        //Sets life on a certain range
        life = Random.Range(2, 4);
        //Spawns a random ammount of asteroids between 1 and 4
        spawnerAsteroids = Random.Range(1, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
    asteroidsVelocity();
        if(life <= 0)
        {
            spawnMiniAsteroids();
            Destroy(asteroid, 0.0f);
        }
    }

    private void asteroidsVelocity()
    {
        transform.Translate(velocity * Time.deltaTime, 0 ,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Bullet")
        {
            life --;
        }
    }

    private void spawnMiniAsteroids()
    {
        for(int i = 0; i < spawnerAsteroids; i ++)
        {
            Instantiate(miniAsteroids, miniAsteroids.transform.position = asteroid.transform.position, miniAsteroids.transform.rotation = asteroid.transform.rotation);
        }
    }
}
