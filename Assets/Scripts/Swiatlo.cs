using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiatlo : MonoBehaviour
{

    //wartosci do tweakowania
    static int czasoczekiwanianarozjasnienie = 5;






//nie tykaæ
    Light myLight;
    int dodolu = 1;
    int dogory = 0;
    float czasciemnosci = czasoczekiwanianarozjasnienie;
    float czasjasnosci = czasoczekiwanianarozjasnienie;
    void Start()
    {
        myLight = GetComponent<Light>();
        
    }

    void Update()
    {
        if (dodolu == 1)
        {
            myLight.intensity -= Time.deltaTime*0.03f;
        }
        if (dogory == 1)
        {
            myLight.intensity += Time.deltaTime*0.03f;
        }
        if (myLight.intensity == 0)
        {
            dodolu = 0;
            czasjasnosci = czasoczekiwanianarozjasnienie;
            czasciemnosci -= Time.deltaTime;
        }
        if (myLight.intensity>=1)
        {
            dogory = 0;
            czasciemnosci = czasoczekiwanianarozjasnienie;
            czasjasnosci -= Time.deltaTime;
        }
        if (czasciemnosci <= 0)
        {
            dogory = 1;
        }
        if (czasjasnosci <= 0)
        {
            dodolu = 1;
        }
    // Debug.Log(myLight.intensity+" dt "+Time.deltaTime/4);
    }
}
