using Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    private void Start()
    {
        var rectTransform = transform as RectTransform;

        rectTransform.SetAnchoredPosition3DX(50f);
        rectTransform.SetAnchoredPosition3DZ(0f);
        rectTransform.SetAnchoredPosition3DXY(10f, 20f);
        
    }
}
