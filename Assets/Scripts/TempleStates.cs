using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleStates : MonoBehaviour
{
    static bool[] figured = new bool[2];
    public static void SetMachineStates(int index)
    {
        if (index < 0 || index >= figured.Length) return;
        figured[index] = true;
        foreach(bool c in figured)
        {
            if (!c) return;
        }
        if(TempleEvents.pass!=null)
        {
            TempleEvents.pass();
        }
    }
}
