using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class coinspawn : MonoBehaviour
{
    public Transform[] coinpos;
    public GameObject coin;
    int coinspawnbetween = 50;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    if (coinspawnbetween == 50)
        {
            Instantiate(coin, coinpos[Random.Range(0, 3)].position, Quaternion.identity);
            coinspawnbetween = 0;
        }
        else
        {
            coinspawnbetween += 1;
        }
    }
}
