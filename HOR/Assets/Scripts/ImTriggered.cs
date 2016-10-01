using UnityEngine;
using System.Collections;

public class ImTriggered : MonoBehaviour {
    public bool IMTRIGGERED;
	// Use this for initialization
	void Start () {
        IMTRIGGERED = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

void OnTriggerEnter() {
        IMTRIGGERED = true;
    }

}
