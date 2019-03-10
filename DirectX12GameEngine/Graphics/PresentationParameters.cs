﻿using DirectX12GameEngine.Games;
using SharpDX.DXGI;

namespace DirectX12GameEngine.Graphics
{
    public class PresentationParameters
    {
        public PresentationParameters(int backBufferWidth, int backBufferHeight, GameContext gameContext, Format backBufferFomat = Format.B8G8R8A8_UNorm, Format depthStencilFormat = Format.D32_Float, bool stereo = false, int syncInterval = 1, PresentParameters presentParameters = default)
        {
            BackBufferWidth = backBufferWidth;
            BackBufferHeight = backBufferHeight;
            BackBufferFormat = backBufferFomat;
            DepthStencilFormat = depthStencilFormat;
            GameContext = gameContext;
            PresentParameters = presentParameters;
            Stereo = stereo;
            SyncInterval = syncInterval;
        }

        public int BackBufferWidth { get; set; }

        public int BackBufferHeight { get; set; }

        public Format BackBufferFormat { get; set; }

        public Format DepthStencilFormat { get; set; }

        public GameContext GameContext { get; set; }

        public PresentParameters PresentParameters { get; set; }

        public bool Stereo { get; set; }

        public int SyncInterval { get; set; }
    }
}