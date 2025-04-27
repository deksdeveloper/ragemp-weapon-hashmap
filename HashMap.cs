using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace HashMap
{
  class HashMapScript : Script
  {
    private static Dictionary<string, WeaponHash> weaponHashMap = new Dictionary<string, WeaponHash>(StringComparer.OrdinalIgnoreCase)
    {
        { "weapon_advancedrifle", (WeaponHash)2937143193u },
        { "weapon_appistol", (WeaponHash)584646201u },
        { "weapon_assaultrifle", (WeaponHash)3220176749u },
        { "weapon_assaultrifle_mk2", (WeaponHash)961495388u },
        { "weapon_assaultshotgun", (WeaponHash)3800352039u },
        { "weapon_assaultsmg", (WeaponHash)4024951519u },
        { "weapon_autoshotgun", (WeaponHash)317205821u },
        { "weapon_ball", (WeaponHash)600439132u },
        { "weapon_bat", (WeaponHash)2508868239u },
        { "weapon_battleaxe", (WeaponHash)3441901897u },
        { "weapon_bottle", (WeaponHash)4192643659u },
        { "weapon_bullpuprifle", (WeaponHash)2132975508u },
        { "weapon_bullpuprifle_mk2", (WeaponHash)2228681469u },
        { "weapon_bullpupshotgun", (WeaponHash)2640438543u },
        { "weapon_bzgas", (WeaponHash)2694266206u },
        { "weapon_carbinerifle", (WeaponHash)2210333304u },
        { "weapon_carbinerifle_mk2", (WeaponHash)4208062921u },
        { "weapon_combatmg", (WeaponHash)2144741730u },
        { "weapon_combatmg_mk2", (WeaponHash)3686625920u },
        { "weapon_combatpdw", (WeaponHash)171789620u },
        { "weapon_combatpistol", (WeaponHash)1593441988u },
        { "weapon_compactlauncher", (WeaponHash)125959754u },
        { "weapon_compactrifle", (WeaponHash)1649403952u },
        { "weapon_crowbar", (WeaponHash)2227010557u },
        { "weapon_dagger", (WeaponHash)2460120199u },
        { "weapon_dbshotgun", (WeaponHash)4019527611u },
        { "weapon_doubleaction", (WeaponHash)2548703416u },
        { "weapon_fireextinguisher", (WeaponHash)101631238u },
        { "weapon_firework", (WeaponHash)2138347493u },
        { "weapon_flare", (WeaponHash)1233104067u },
        { "weapon_flaregun", (WeaponHash)1198879012u },
        { "weapon_flashlight", (WeaponHash)2343591895u },
        { "weapon_golfclub", (WeaponHash)1141786504u },
        { "weapon_grenade", (WeaponHash)2481070269u },
        { "weapon_grenadelauncher", (WeaponHash)2726580491u },
        { "weapon_grenadelauncher_smoke", (WeaponHash)1305664598u },
        { "weapon_gusenberg", (WeaponHash)1627465347u },
        { "weapon_hammer", (WeaponHash)1317494643u },
        { "weapon_hatchet", (WeaponHash)4191993645u },
        { "weapon_heavypistol", (WeaponHash)3523564046u },
        { "weapon_heavyshotgun", (WeaponHash)984333226u },
        { "weapon_heavysniper", (WeaponHash)205991906u },
        { "weapon_heavysniper_mk2", (WeaponHash)177293209u },
        { "weapon_hominglauncher", (WeaponHash)1672152130u },
        { "weapon_knife", (WeaponHash)2578778090u },
        { "weapon_knuckle", (WeaponHash)3638508604u },
        { "weapon_machete", (WeaponHash)3713923289u },
        { "weapon_machinepistol", (WeaponHash)3675956304u },
        { "weapon_marksmanpistol", (WeaponHash)3696079510u },
        { "weapon_marksmanrifle", (WeaponHash)3342088282u },
        { "weapon_marksmanrifle_mk2", (WeaponHash)1785463520u },
        { "weapon_mg", (WeaponHash)2634544996u },
        { "weapon_microsmg", (WeaponHash)324215364u },
        { "weapon_minigun", (WeaponHash)1119849093u },
        { "weapon_minismg", (WeaponHash)3173288789u },
        { "weapon_molotov", (WeaponHash)615608432u },
        { "weapon_musket", (WeaponHash)2828843422u },
        { "weapon_nightstick", (WeaponHash)1737195953u },
        { "weapon_parachute", (WeaponHash)4222310262u },
        { "weapon_petrolcan", (WeaponHash)883325847u },
        { "weapon_pipebomb", (WeaponHash)3125143736u },
        { "weapon_pistol", (WeaponHash)453432689u },
        { "weapon_pistol_mk2", (WeaponHash)3219281620u },
        { "weapon_pistol50", (WeaponHash)2578377531u },
        { "weapon_poolcue", (WeaponHash)2484171525u },
        { "weapon_proximine", (WeaponHash)2381443905u },
        { "weapon_pumpshotgun", (WeaponHash)487013001u },
        { "weapon_pumpshotgun_mk2", (WeaponHash)1432025498u },
        { "weapon_railgun", (WeaponHash)1834241177u },
        { "weapon_revolver", (WeaponHash)3249783761u },
        { "weapon_revolver_mk2", (WeaponHash)3415619887u },
        { "weapon_rpg", (WeaponHash)2982836145u },
        { "weapon_sawnoffshotgun", (WeaponHash)2017895192u },
        { "weapon_smg", (WeaponHash)736523883u },
        { "weapon_smg_mk2", (WeaponHash)2024373456u },
        { "weapon_smokegrenade", (WeaponHash)4256991824u },
        { "weapon_sniperrifle", (WeaponHash)100416529u },
        { "weapon_snowball", (WeaponHash)126349499u },
        { "weapon_snspistol", (WeaponHash)3218215474u },
        { "weapon_snspistol_mk2", (WeaponHash)2285322324u },
        { "weapon_stone_hatchet", (WeaponHash)940833800u },
        { "weapon_specialcarbine", (WeaponHash)3231910285u },
        { "weapon_specialcarbine_mk2", (WeaponHash)2526821735u },
        { "weapon_stickybomb", (WeaponHash)741814745u },
        { "weapon_stungun", (WeaponHash)911657153u },
        { "weapon_switchblade", (WeaponHash)3756226112u },
        { "weapon_unarmed", (WeaponHash)2725352035u },
        { "weapon_vintagepistol", (WeaponHash)137902532u },
        { "weapon_wrench", (WeaponHash)419712736u },
        { "weapon_raypistol", (WeaponHash)2939590305u },
        { "weapon_raycarbine", (WeaponHash)1198256469u },
        { "weapon_rayminigun", (WeaponHash)3056410471u },
        { "weapon_ceramicpistol", (WeaponHash)727643628u },
        { "weapon_hazardcan", (WeaponHash)3126027122u },
        { "weapon_navyrevolver", (WeaponHash)2441047180u }
    };

    // Example: GetWeaponHashFromModelName("weapon_pistol");
    // Output: Pistol
    public static WeaponHash GetWeaponHashFromModelName(string modelName)
    {
        if (weaponHashMap.TryGetValue(modelName, out WeaponHash hash))
        {
            return hash;
        }
    
        if (!modelName.StartsWith("weapon_", StringComparison.OrdinalIgnoreCase))
        {
            string prefixedName = "weapon_" + modelName;
            if (weaponHashMap.TryGetValue(prefixedName, out hash))
            {
                return hash;
            }
        }
    
        return WeaponHash.Unarmed;
    }
  }
}
