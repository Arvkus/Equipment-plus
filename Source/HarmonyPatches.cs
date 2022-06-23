using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using UnityEngine;         // Always needed
using Verse;               // RimWorld universal objects are here (like 'Building')
using Verse.AI;            // Needed when you do something with the AI
using Verse.AI.Group;
using Verse.Sound;         // Needed when you do something with Sound
using Verse.Noise;         // Needed when you do something with Noises
using RimWorld;            // RimWorld specific functions are found here (like 'Building_Battery')
using RimWorld.Planet;     // RimWorld specific functions for world creation

using HarmonyLib;

namespace EqPlus
{
    // Pawn_EquipmentTracker - Gear Equipment (Weapons)
    // Pawn_InventoryTracker - Gear Inventory

    [HarmonyPatch(typeof(Pawn_EquipmentTracker), "DropAllEquipment")]
    public class StopDrop
    { 
        private static bool Prefix(ref IntVec3 pos, bool forbid, Pawn_EquipmentTracker __instance){
            bool isDowned = __instance.pawn.Downed;
            bool isDead = __instance.pawn.Dead;
            return isDead; // if dead - drop
            // return false; // skip original method
        }
    }

}