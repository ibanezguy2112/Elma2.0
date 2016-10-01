using UnityEngine;
using System.Collections;

public class BabySound : MonoBehaviour
{

    //GameObject
    public GameObject ScareMesh;
    AudioSource AudioS;
    public AudioClip[] JumpList;
    bool is_Triggered;
    public Light[] Lights;
    bool done;
    bool has_run;

    // Use this for initialization
    void Start()
    {
        AudioS = GetComponent<AudioSource>();
        is_Triggered = false;
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ScareMesh.GetComponent<ImTriggered>().IMTRIGGERED == true) {
            DoTheTrigger();
        }
    }
//Do the thing

    void DoTheTrigger()
    {
        if (!is_Triggered)
        {
            if (!has_run)
            {
                AudioS.clip = JumpList[0];
                AudioS.Play();
                has_run = true;
            }
            
            if (!AudioS.isPlaying)
            {

                AudioS.clip = JumpList[1];
                AudioS.Play();
                is_Triggered = true;
            }
        }
        if (!AudioS.isPlaying && !done && is_Triggered)
        {
            
            Debug.Log("ClipOver Lights Out");
            for (int i = 0; i < Lights.Length; i++)
             {
                Light Currentlight = Lights[i].GetComponent<Light>();
                Currentlight.intensity = 0;
            }
            done = true;

        }


    }


}
