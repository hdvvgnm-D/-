using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TempleEvents : MonoBehaviour
{
    //静态变量方便类名直接访问
    //传送委托
    public static Action<Transform> transmit;
    //机关解除委托
    public static Action<int> figure;
    //机关旋转和通过委托
    public static Action rotate,pass;
}
