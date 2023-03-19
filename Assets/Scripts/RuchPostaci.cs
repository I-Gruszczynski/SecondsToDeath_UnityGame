using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchPostaci : MonoBehaviour
{
    public float szybkosc = 8.5f;

    void Update()
    {
        PoruszajGraczem();
        OgraniczajRuch();
    }

    void PoruszajGraczem()
    {
        float ruchPoziomy = Input.GetAxisRaw("Horizontal");
        float ruchPionowy = Input.GetAxisRaw("Vertical");
        Vector2 ruchGracza = new Vector2(ruchPoziomy, ruchPionowy);
        ruchGracza = ruchGracza * szybkosc * Time.deltaTime;
        transform.Translate(ruchGracza);
    }

    void OgraniczajRuch()
    {
        Vector3 wektorOgraniczenia = transform.position;
        wektorOgraniczenia.x = Mathf.Clamp(wektorOgraniczenia.x, -8.5f, 5.7f);
        wektorOgraniczenia.y = Mathf.Clamp(wektorOgraniczenia.y, -4.32f, 3f);
        transform.position = wektorOgraniczenia;
    }
}
