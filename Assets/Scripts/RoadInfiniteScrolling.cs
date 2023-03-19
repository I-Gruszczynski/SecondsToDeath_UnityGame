using UnityEngine;
using System.Collections;

public class RoadInfiniteScrolling : MonoBehaviour {

    public float scrollSpeed;
    private Vector2 offset;

    void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
