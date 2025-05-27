using UnityEngine;
using System;
using UnityEngine.UI;

public class ShopCategoryButton : MonoBehaviour
{
    public event Action click;

    [SerializeField] private Button _button;

    [SerializeField] private Image _image;
    [SerializeField] private Color _selectColor;
    [SerializeField] private Color _unselectColor;

    private void OnEnable() => _button.onClick.AddListener(OnClicks);
    private void OnDisable() => _button.onClick.RemoveListener(OnClicks);

    public void Select() => _image.color = _selectColor;
    public void UnSelect() => _image.color = _unselectColor;

    private void OnClicks() => click?.Invoke();
}

