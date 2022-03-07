using Redcode.Extensions;
using UnityEngine;

namespace Redcode.Demo
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