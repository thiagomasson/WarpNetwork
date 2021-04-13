﻿using StardewModdingAPI;

namespace WarpNetwork
{
    class CPIntegration
    {
        private static IMonitor Monitor;
        private static IModHelper Helper;
        private static Config Config;
        public static void Init(IMonitor monitor, IModHelper helper, Config config)
        {
            Monitor = monitor;
            Helper = helper;
            Config = config;
        }
        public static void AddTokens(IManifest manifest)
        {
            if (!Helper.ModRegistry.IsLoaded("pathoschild.ContentPatcher"))
                return;
            var api = Helper.ModRegistry.GetApi<IContentPatcherAPI>("Pathoschild.ContentPatcher");
            api.RegisterToken(manifest, "MenuEnabled", () => new[] { Config.MenuEnabled.ToString() });
        }
    }
}