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
    }else
    {

        PauseGame();

    }
     
    }
    void GetCurrentFill(){
        float fillAmount = (float)current/(float)maximum;
        mask.fillAmount = fillAmount;

    }


    void PauseGame(){
        Time.timeScale=0;
        GameManagerTasks.GameEnded();
    }
    void UnPauseGame(){
        Time.timeScale=1;
    }

}
