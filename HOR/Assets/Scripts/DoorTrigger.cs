using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{

    //GameObject
    public GameObject ScareMesh;
 
    bool is_Triggered;
    bool is_Opened;

    // Use this for initialization
    void Start()
    {
        is_Triggered = false;
        is_Opened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScareMesh.GetComponent<ImTriggered>().IMTRIGGERED == true)
        {
            DoTheTrigger();
        }
    }
    //Do the thing

    public void DoTheTrigger()
    {
        Debug.Log("DoorTrigger Started");
      if (is_Opened)
        {
            StartCoroutine(RotateMe(Vector3.up * -115, 1));
        }

        if (!is_Opened)
        {
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
