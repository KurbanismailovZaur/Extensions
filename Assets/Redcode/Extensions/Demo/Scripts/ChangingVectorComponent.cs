using Redcode.Extensions;
using UnityEngine;

namespace Redcode.Demo
{
    public class ChangingVectorComponent : MonoBehaviour
    {
        [SerializeField]
        private Transform _control;

        [SerializeField]
        private Transform _target;

        private void Update()
        {
            _control.SetPositionXZ(-5f + Mathf.PingPong(Time.time + 5f, 10f), -5f + Mathf.PingPong(Time.time * 2f + 15f, 10f));
            _target.position = _control.position.WithY(0f);

            Debug.DrawLine(_control.position, _control.position.WithY(0f), Color.yellow); 
        }
    }
}