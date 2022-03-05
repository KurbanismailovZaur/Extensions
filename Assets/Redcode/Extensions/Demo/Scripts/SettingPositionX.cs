using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extensions;

namespace Demo
{
    public class SettingPositionX : MonoBehaviour
    {
        [SerializeField]
        private Transform _target;

        private void Start()
        {
            _target.SetPositionX(1f);
        }
    }
}