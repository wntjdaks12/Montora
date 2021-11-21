using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�е� �����̴�
public class PaddleSlider : MonoBehaviour
{
    //�����̴� ����Դϴ�.
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    /// <summary>
    /// �����̴� ���� �����մϴ�.
    /// </summary>
    /// <param name="val"></param>
    public void setValue(float val)
    {
        if (slider == null)
            return;

        slider.value = val;
    }
}
