using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    //door
    public bool is_Opened;
    public bool is_Moving;


	// Use this for initialization
	void Start () {
        is_Opened = false;
       
    }
	
	// Update is called once per frame
	void Update () {
	



	}

public void Interact() {
        if (!is_Moving)
        {
            if (is_Opened)
            {
                is_Moving = true;
                StartCoroutine(RotateMe(Vector3.up * 115, 2));
            }

            if (!is_Opened)
            {
                StartCoroutine(RotateMe(Vector3.up * -115, 2));
                is_Moving = true;
            }
        }
}



    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t);
            yield return null;
        }
        is_Opened = !is_Opened;
        is_Moving = false;
    }
}
