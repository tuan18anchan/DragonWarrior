using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausecotroller : MonoBehaviour
{
    public GameObject Pausedmenu;
    public void resume()
    {
        Pausedmenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
