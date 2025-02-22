﻿using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace CustomizedStorage
{
    [BepInPlugin(myGUID, MODNAME, VERSION)]
    public class CustomizedStorage : BaseUnityPlugin
    {

        // Mod Information: Edit the size/capacity of any container in the game, including the player inventory!
        // Original Base Code by RandyKnapp - Updated for BepInEx by d2allgr
        public const string
            MODNAME = "CustomizedStorage",
            AUTHOR = "RandyKnapp",
            myGUID = "com." + AUTHOR + "." + MODNAME,
            VERSION = "1.0.6.0";

        private void Awake()
        {
            Mod.LoadConfig();
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), myGUID);
            Logger.LogInfo(MODNAME + " " + VERSION + " " + "loaded.");
        }
    }
}