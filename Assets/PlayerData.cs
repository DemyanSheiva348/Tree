using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class PlayerData
{
    private CharacterSkins _selectedCharacterSkin;
    private List<CharacterSkins> _openCharacterSkins;
    private int _money;

    public PlayerData()
    {
        _money = 10000;
        _selectedCharacterSkin = CharacterSkins.Itachi;
        _openCharacterSkins = new List<CharacterSkins>() { _selectedCharacterSkin };
    }

    [JsonConstructor]
    public PlayerData(int money, CharacterSkins selectedCharacterSkin, List<CharacterSkins> openCharacterSkins)
    {
        Money = money;
        _selectedCharacterSkin = selectedCharacterSkin;
        _openCharacterSkins = new List<CharacterSkins>(openCharacterSkins);
    }

    public int Money
    {
        get => _money;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            _money = value;
        }
    }

    public CharacterSkins SelectedCharacterSkin
    {
        get => _selectedCharacterSkin;
        set
        {
            if (_openCharacterSkins.Contains(value) == false)
                throw new ArgumentException(nameof(value));
            _selectedCharacterSkin = value;
        }
    }

    public IEnumerable<CharacterSkins> OpenCharacterSkins => _openCharacterSkins;

    public void OpenCharacterSkinsMethod(CharacterSkins skin)
    {
        if (_openCharacterSkins.Contains(skin))
            throw new ArgumentException(nameof(skin));

        _openCharacterSkins.Add(skin);
    }
}

