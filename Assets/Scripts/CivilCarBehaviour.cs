using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilCarBehaviour : MonoBehaviour
{
    public float civilCarSpeed = 5f;
    public int direction = -1;



    private Vector3 civilCarPosition;




    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(direction, 0, 0) * civilCarSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {

        }
        else if (obj.gameObject.tag == "EndOfTheRoad")
        {
            Destroy(this.gameObject);
        }
    }


}
// Wylaczone bo nie uzywane i generowalo caution
/*public class CivilCarBehaviourSlower : CivilCarBehaviour
{
    float szybkosc = 3.5f;

}*/
// Wylaczone bo nie uzywane i generowalo caution
/*public class CivilCarBehaviourFaster : CivilCarBehaviour
{
    float szybkoszc = 8.5f;
}*/

