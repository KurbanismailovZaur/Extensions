using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extensions;
using UnityEngine.UI;

namespace Demo
{
    public class GettingComponentsXZ : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _background;

        [SerializeField]
        private RectTransform _point;

        private void Update()
        {
            if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                return;

            // Get ground point with GetXZ method and scale it by background size.
            _point.anchoredPosition = hit.point.GetXZ() * (_background.sizeDelta / 10f);
        }
    }
}