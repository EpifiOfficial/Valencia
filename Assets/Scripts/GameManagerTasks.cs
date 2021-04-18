using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTasks : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject repeatBtn;
    public GameObject disableMusic;
    public GameObject homePanel;
    public GameObject finishPanel;
    public GameObject mainLoop;
    public GameObject progressBar;
    // Start is called before the first frame update
    void Start()
    {

        mainLoop.active = true;
        progressBar.active = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Play(){
        homePanel.active = false;
        mainLoop.active = true;
        progressBar.active= true;
        

    }
    public void PlayAgain(){

        GameManager.currentNumberStonesDestroyed= 0;
        finishPanel.active = false;
        mainLoop.active = true;
        progressBar.active = true;

    }
}
