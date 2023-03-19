using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameManagerScript gameManagerScript;
    public GameObject samochod;
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManagerScript>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit detection");
        gameManagerScript.ZmienScene(2);
        Destroy(samochod);
    }
}
