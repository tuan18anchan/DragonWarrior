using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heathbar : MonoBehaviour
{
    public Slider slider;
    public Color low;
    public Color high;
    public Vector3 offset;
    public void Setheathbar(float heath, float maxheath)
    {
        slider.gameObject.SetActive(heath<maxheath);
        slider.value = heath;
        slider.maxValue= maxheath;

        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position=Camera.main.WorldToScreenPoint(transform.parent.position+offset);
    }
}
