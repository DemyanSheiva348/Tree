public class SkinUnlocker : IShopItemVisitor
{
    private IPersistentData _persistentData;

    public SkinUnlocker(IPersistentData persistentData) =>
        _persistentData = persistentData;

    public void Visit(ShopItem shopItem) =>
        Visit((dynamic)shopItem); // правильное использование dynamic

    public void Visit(CharacterSkinItem characterSkinItem) =>
        _persistentData.PlayerData.OpenCharacterSkinsMethod(characterSkinItem.SkinType);
}

