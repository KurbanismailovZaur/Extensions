using Redcode.Extensions;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Vector4.zero.With(0, 1f, 2, 3.14f);
    }
}
