using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    private int shotCounter = 0;
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        //Initiate variable for TextMeshProGUI
        text = GetComponent<TextMeshProUGUI>();

        UpdateText();
    }

    private void UpdateText()
    {
        text.text = shotCounter.ToString();
        Debug.Log(shotCounter);
    }

    public void IncreaseCounter()
    {
        shotCounter++;
        UpdateText();
    }

    public void ResetCounter()
    {
        shotCounter = 0;
        UpdateText();
    }
}
