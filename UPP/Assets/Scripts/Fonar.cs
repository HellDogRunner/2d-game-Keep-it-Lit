using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonar : MonoBehaviour
{
    public GameObject fire, move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            fire.SetActive(true);
            if (move)
            move.SetActive(true);
        }
    }
}