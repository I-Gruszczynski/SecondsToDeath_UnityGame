using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public void ZmienScene(int numerSceny)
    {
        SceneManager.LoadScene(numerSceny);
    }

    public void OpuscGre()
    {
        Application.Quit();
    }
}
