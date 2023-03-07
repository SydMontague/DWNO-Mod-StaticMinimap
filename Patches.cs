using HarmonyLib;
using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StaticMinimap
{
    class Patches
    {
        [HarmonyPatch(typeof(uMinimap), "Update")]
        [HarmonyPostfix]
        static void uMinimap_Update_Postfix(uMinimap __instance)
        {
            if (__instance.m_mainCamera != null)
            {
                __instance.m_north.localRotation = Quaternion.Euler(0f, 0f, MainGameManager.Ref.dayAndNightScript.m_northDirection);
                __instance.m_tamer.localRotation = Quaternion.Euler(0f, 0f, -__instance.m_player.localEulerAngles.y);
                __instance.m_northDirection = Quaternion.Euler(0f, 0f, 0f);
            }

            if(__instance.IsOpened())
                __instance.m_mapRoot.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }

        [HarmonyPatch(typeof(uMinimap), "CreateMarker")]
        [HarmonyPrefix]
        static bool uMinimap_CreateMarker_Prefix(uMinimap __instance)
        {
            if (__instance.m_mainCamera != null)
            {
                __instance.m_north.localRotation = Quaternion.Euler(0f, 0f, MainGameManager.Ref.dayAndNightScript.m_northDirection);
                __instance.m_tamer.localRotation = Quaternion.Euler(0f, 0f, -__instance.m_player.localEulerAngles.y);
                __instance.m_northDirection = Quaternion.Euler(0f, 0f, 0f);
            }

            if (__instance.IsOpened())
                __instance.m_mapRoot.localRotation = Quaternion.Euler(0f, 0f, 0f);

            return true;
        }

    }
}
