using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CivilCarSpawner : MonoBehaviour {
    public float carSpawnDelay = 2f;
    public GameObject civilCar;
    int lane;
    int last1 = 1;
    int last2 = 2;
    private float[] lanesArray;
    // final 90 : 3 
    float czasdosekwencjikoncowej = 10;
    float pustaulicasekwencjikoncowej = 3;
    private float spawnDelay;
    void Start()
    {
        lanesArray = new float[6];
        lanesArray[0] = 5.37f;
        lanesArray[1] = 2.62f;
        lanesArray[2] = -0.29f;
        lanesArray[3] = 4.27f;
        lanesArray[4] = 1.41f;
        lanesArray[5] = -1.34f;
        spawnDelay = carSpawnDelay;
    }

    void Update() {
        Debug.Log("czasdosekwencjikoncowej" + czasdosekwencjikoncowej + "pustaulicasekwencjikoncowej" + pustaulicasekwencjikoncowej);
        Scene scene = SceneManager.GetActiveScene();
        //Debug.Log(scene.name);
        if (czasdosekwencjikoncowej > 0 && scene.name == "SampleScene") {
            czasdosekwencjikoncowej -= Time.deltaTime;
            //Debug.Log(czasdosekwencjikoncowej);
            spawnDelay -= Time.deltaTime;
        }
        if (spawnDelay <= 0)
        {
            spawnCar();
            spawnDelay = carSpawnDelay;
        }
        if (pustaulicasekwencjikoncowej > 0 && czasdosekwencjikoncowej <= 0) {

            pustaulicasekwencjikoncowej -= Time.deltaTime; }
        Debug.Log("czasdosekwencjikoncowej" + czasdosekwencjikoncowej + "pustaulicasekwencjikoncowej" + pustaulicasekwencjikoncowej);
        if (pustaulicasekwencjikoncowej <= 0)
        {
            //Debug.Log("ZMIANA SCENY");
            SceneManager.LoadScene(4); }
    }

    void spawnCar()
    {
        do { lane = Random.Range(0, 6); }
        while (last1 == lane && last2 == lane);
        Instantiate(civilCar, new Vector3(14f, lanesArray[lane], -0.6f), Quaternion.identity);
        last2 = last1;
        last1 = lane;

    }
}
