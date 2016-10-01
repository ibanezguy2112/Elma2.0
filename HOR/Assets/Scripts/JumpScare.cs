using UnityEngine;
using System.Collections;

public class JumpScare : MonoBehaviour {

    //GameObject
    public GameObject ScareMesh;
    public GameObject TargetArea;
    AudioSource AudioS;
    public AudioClip[] JumpList;

    bool is_Triggered;

    // Use this for initialization
    void Start () {
        AudioS = GetComponent<AudioSource>();
        is_Triggered = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

void OnTriggerEnter() {
        if (!is_Triggered)
        {
            ScareMesh.transform.position = TargetArea.transform.position;
            ScareMesh.transform.rotation = TargetArea.transform.rotation;
            AudioS.clip = JumpList[0];
            AudioS.Play();
            is_Triggered = true;
        }

    }


}
