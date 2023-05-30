using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoretext : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int scoreamount=0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = scoreamount.ToString();
    }
}
