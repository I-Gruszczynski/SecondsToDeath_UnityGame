using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
    float final = 3;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 1.5)
        {
            transform.position = new Vector3(transform.position.x + (Time.deltaTime * 5), -2.16f, -5);
        }
        else
        {
            if (final >= 0) {final -= Time.deltaTime;
            }
            if (final <= 0) {SceneManager.LoadScene(3); }
        }
    }
}
