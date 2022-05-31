﻿using WarpNetwork.api;

namespace WarpNetwork.models
{
    class CustomWarpLocation : WarpLocation
    {
        public readonly IWarpNetHandler handler;
        public CustomWarpLocation(IWarpNetHandler handler) : base()
        {
            this.handler = handler;
        }
        public override string Label
        {
            get => handler.GetLabel();
        }
        public override string Icon
        {
            get => handler.GetIconName();
        }
        public override bool Enabled
        {
            get => handler.GetEnabled();
        }
    }
}
