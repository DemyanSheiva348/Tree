public class SelectedSkinsChecker : IShopItemVisitor
{
    private IPersistentData _persistentData;

    public bool IsSelected { get; private set; }

    public SelectedSkinsChecker(IPersistentData persistentData) => _persistentData = persistentData;

    public void Visit(ShopItem shopItem) => Visit((dynamic)shopItem);

    public void Visit(CharacterSkinItem characterSkinItem)
        => IsSelected = _persistentData.PlayerData.SelectedCharacterSkin == characterSkinItem.SkinType;
}

