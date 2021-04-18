using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class Progressbar : MonoBehaviour
{
    public int maximum;
    public int current;
    float time ;
    public Image mask;
    public GameObject finishPanel;
    public GameObject mainLoop;
    // Start is called before the first frame update
    void Start()
    {
        time=0f;
    }

    // Update is called once per frame
    void Update()
    {
    if(time<maximum){
         time = time + 1*Time.deltaTime;
         current=(int)time;
         GetCurrentFill(); 
    }else{
        GameEnd();
 }
     
    }
    void GetCurrentFill(){


        float fillAmount = (float)current/(float)maximum;
        mask.fillAmount = fillAmount;


    }


    
    void GameEnd(){


        mainLoop.active = false;
        finishPanel.active = true;
        gameObject.active=false;

    }

}
