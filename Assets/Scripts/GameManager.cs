using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player, rotateCube;
    public GameObject[] lights;
    public GameObject fence;
    // Start is called before the first frame update
    void Start()
    {
        //print("HHHH\n");
        //更改角色位置
        TempleEvents.transmit += pos =>
        {
            player.position = pos.position;
            player.rotation = pos.rotation;
        };
        //设置状态并关闭对应盏红灯
        TempleEvents.figure += index =>
        {
            TempleStates.SetMachineStates(index);
            lights[index].SetActive(false);
        };
        //旋转45度
        TempleEvents.rotate += () => rotateCube.Rotate(Vector3.up * 45, Space.Self);
        //关闭围栏
        TempleEvents.pass += () => fence.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
