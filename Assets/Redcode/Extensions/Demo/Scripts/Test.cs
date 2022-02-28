using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extensions;

namespace Demo
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            // Setting position to game object.
            transform.SetPositionX(1f);

            // Getting components from vector.
            var xzVector = transform.position.GetXZ();

            // Changing vector components.
            var groundPos = transform.position.WithY(0f);

            // Extending vector.
            var extendedVector = xzVector.InsertY(0f);

            // Destroying childs by condition.
            transform.DestroyChildsWhere(c => c.name.StartsWith("abc"));

            // And many other things!
            // Read documentation for more information..
        }
    }
}