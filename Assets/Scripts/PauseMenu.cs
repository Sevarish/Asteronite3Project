using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public GameObject PauseUI;

    private bool paused = false;

    void Start(){

        PauseUI.SetActive(false);

    }

    void Update() {
    
        if (Input.GetButtonDown("Pause")) {

            paused = !paused;

        }

        if (paused == true) {
       
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (paused == false) {

            PauseUI.SetActive(false);
            Time.timeScale = 1;

        }

    }

    public void Resume() {

        paused = false;

    }


    public void Restart() {

        Application.LoadLevel(Application.loadedLevel);

    }

    public void MainMenu() {

        Application.LoadLevel(0);

    }

    public void Quit() {

        Application.Quit();

    }



}
