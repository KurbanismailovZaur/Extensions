using Redcode.Extensions;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField]
    private RenderTexture _renderTexture;

    [SerializeField]
    private Image _image;

    private Sprite _sprite;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        _sprite = _renderTexture.ToSprite();
        _image.sprite = _sprite;
        _renderTexture.WriteToSprite(_sprite);
    }

    private void Update()
    {
    }
}
