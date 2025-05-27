using System.Linq;

public class OpenSkinChecker : IShopItemVisitor
{
    private IPersistentData _persistentData;
    public bool IsOpened { get; private set; }
    public OpenSkinChecker(IPersistentData persistentData) => _persistentData = persistentData;
    public void Visit(ShopItem shopItem) => Visit((dynamic)shopItem);
    public void Visit(CharacterSkinItem characterSkinItem) => IsOpened = _persistentData.PlayerData.OpenCharacterSkins.Contains(characterSkinItem.SkinType);
}
