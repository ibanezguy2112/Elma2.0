using UnityEngine;
using System.Collections;

public class Interactabledoor : MonoBehaviour {

    public int ID;

    //door
    public bool is_Opened;


	// Use this for initialization
	void Start () {
        is_Opened = false;
       
    }
	
	// Update is called once per frame
	void Update () {
	



	}

public void Interact() {

        if (is_Opened)
        {
            StartCoroutine(RotateMe(Vector3.up * -115, 1));
        }

        if(!is_Opened) { 
        StartCoroutine(RotateMe(Vector3.up * 115, 1));
    }
}


    //Door and this is
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
    }
}
