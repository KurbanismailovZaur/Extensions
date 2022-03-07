using Redcode.Extensions;
using UnityEngine;

namespace Redcode.Demo
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