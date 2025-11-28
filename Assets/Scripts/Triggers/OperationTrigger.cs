using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationTrigger : MonoBehaviour
{
    public int index;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "machineTrigger")
            TempleEvents.figure?.Invoke(index);
    }
}
