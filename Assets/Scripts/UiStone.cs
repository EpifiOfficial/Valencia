using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UiStone : MonoBehaviour
{
    public TextMeshProUGUI destroyedStones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyedStones.text = ""+GameManager.currentNumberStonesDestroyed;
    }
}
