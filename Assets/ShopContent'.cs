using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopContent", menuName = "Shop/ShopContent")]
public class ShopContent : ScriptableObject
{
    [SerializeField] private List<CharacterSkinItem> _characterSkinItems;
    public IEnumerable<CharacterSkinItem> CharacterSkinItems => _characterSkinItems;

    private void OnValidate()
    {
        var characterSkinsDuplicates = _characterSkinItems.GroupBy(item => item.SkinType)
        .Where(array => array.Count() > 1);

        if (characterSkinsDuplicates.Count() > 0)
            throw new InvalidOperationException(nameof(_characterSkinItems));
    }
}
