using UnityEngine;
using System.Collections;

public class PlayerControlsEX : MonoBehaviour {
    //Audio
    AudioSource AudioS;
    public AudioClip[] SfxList;

    //FlashLight
    public GameObject Flashlight;
    bool FlashlightActive;

    //E Interact
    public float maxRayDistance;
       Camera camera;
    Interactable Interaction;
    GameObject IntractableText;

    // Use this for initialization
    void Start () {
        AudioS = GetComponent<AudioSource>();
        IntractableText = GameObject.FindGameObjectWithTag("IntractableText");
        IntractableText.SetActive(false);
        camera = GetComponentInChildren<Camera>();
        
    }
	
	// Update is called once per frame
	void Update () {
        //Checks
        CheckForAvaibleInteraction();




     if (Input.GetKeyUp(KeyCode.F))
        {
            FlashlightActive = !FlashlightActive;

            if(FlashlightActive) {
                Flashlight.SetActive(false);
                AudioS.clip = SfxList[0];
                AudioS.Play();
            }
            if(!FlashlightActive) {
                Flashlight.SetActive(true);
                AudioS.clip = SfxList[0];
                AudioS.Play();
            }

        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("EKey");
            EKey();

        }
        


    }

    void EKey()
    {
      
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Interact Phase A");
            print("I'm looking at " + hit.transform.name);
            Interaction = hit.transform.GetComponent<Interactable>();
            if (Interaction == null)
           {
               
            }
            else
            {
                Debug.Log("Interact Phase B");
                if (hit.distance <= maxRayDistance)
                {
                    Debug.Log("Interact Phase C");
                    Debug.Log("hit.distance: " +hit.distance);
                    Debug.Log("maxRayDistance: " + maxRayDistance);
                    Interaction.Interact();
                }
            }
            
         }
        else {
            print("I'm looking at nothing!");
        }
    }


    void CheckForAvaibleInteraction()
    {

        Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
               if(hit.transform.tag == "Intractable"  && hit.distance <= maxRayDistance) {
                IntractableText.SetActive(true);
            }
            else 
            {
                IntractableText.SetActive(false);
            }      
        }
        else {
            print("I'm looking at nothing!");
        }
    }
}
    


