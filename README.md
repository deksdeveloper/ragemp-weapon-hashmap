# RageMP Weapon Hash Mapper

This repository contains a C# implementation of a weapon hash mapping system for RageMP servers. The mapper helps convert weapon model names (like `weapon_pistol`) to their corresponding hash values used internally by GTA V and RageMP.

## Problem This Solves

One common issue in RageMP server development is correctly converting string-based weapon names to their corresponding hash values. This can be problematic due to:
- Case sensitivity issues
- Character encoding problems (especially with non-ASCII characters)
- Inconsistent naming conventions

This weapon hash mapper provides a reliable solution by explicitly mapping each weapon name to its correct hash value.

## Features

- Complete mapping of all GTA V weapons to their correct hash values
- Case-insensitive string comparison for weapon names
- Automatic handling of "weapon_" prefix if missing

## Usage Example

```csharp
// Example usage
public static void GiveWeapon(Player player, string weapon)
{
    WeaponHash hash = GetWeaponHashFromModelName(weapon);    
    if (hash == WeaponHash.Unarmed)
    {
        Console.WriteLine("Incorrect weapon model!");
        return;
    }
    
    NAPI.Player.GivePlayerWeapon(player, hash, 40); 
}
```

## Weapon Hash Dictionary

The repository includes a comprehensive dictionary that maps all weapon model names to their correct hash values, ensuring consistent behavior across different RageMP server environments.

## Installation

Simply include the HashMap.cs file in your RageMP server project and call the `GetWeaponHashFromModelName` method whenever you need to convert a weapon name to its hash.

## License

This code is provided as-is under the MIT License. Feel free to use and modify it for your RageMP server projects.
