using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ����
public class DataManager : MonoBehaviour
{
    private void Start()
    {
        new BrickJson().ReadData();
    }
}
