using UnityEngine;
using System.Collections;


public class sceneManger : MonoBehaviour {



    //Menus
    bool PauseOpen;
    GameObject Pause;
    GameObject Player;

	// Use this for initialization
	void Start () {
        Pause = GameObject.FindGameObjectWithTag("PauseMenu");
        Pause.SetActive(false);
        PauseOpen = false;
        Time.timeScale = 1f;
       // Player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>;
    }

    // Update is called once per frame

void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && Application.loadedLevel > 0)
          {
            DoPausestuff();

          }
    }

    public void LoadScene(int level)
    {
        
        Application.LoadLevel(level);

    }

    public void RestartScene()
    {
        var whatscene = Application.loadedLevel;
        Application.LoadLevel(whatscene);
    }

    public void NextScene()
    {
        var whatscene = Application.loadedLevel + 1;
        Application.LoadLevel(whatscene);

    }

    public void QuitGame() {
        Application.Quit();
    }


    void togglePause()
    {

        
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            Debug.Log("Toggle pause activated");
        }
        else
        {
            Time.timeScale = 0f;
            Debug.Log("Toggle pause De-activated");
        }
    }
    public void DoPausestuff() {
        PauseOpen = !PauseOpen;
        if (PauseOpen)
        {
            //togglePause();
            Pause.SetActive(false);
                    
        }

        if (!PauseOpen)
        {
            Pause.SetActive(true);
           // togglePause();
        }
    }

}
