using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extensions;
using UnityEngine.UI;

namespace Demo
{
    public class DestroyChildsWhere : MonoBehaviour
    {
        [SerializeField]
        private Transform _target;

        private void Update()
        {
            _target.DestroyChildsWhere(c => c.name == "Enemy");
        }
    }
}