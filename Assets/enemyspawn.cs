using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemyspawn : MonoBehaviour
{
    public Transform[] enemypos;
    public GameObject enemy;
    int enemyspawnbetween = 50;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (enemyspawnbetween == 50)
        {
            Instantiate(enemy, enemypos[Random.Range(0, 3)].position, Quaternion.identity);
            enemyspawnbetween = 0;
        }
        else
        {
            enemyspawnbetween += 1;
        }
    }
}