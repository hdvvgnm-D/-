using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTrigg : MonoBehaviour
{
    bool inArea;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") inArea = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") inArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inArea&&Input.GetKeyDown(KeyCode.J))
        {
            TempleEvents.rotate?.Invoke();
        }
    }
}
