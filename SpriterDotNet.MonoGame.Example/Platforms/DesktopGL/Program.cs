﻿// Copyright (c) 2017 The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

using System;

namespace SpriterDotNet.MonoGame.Example.DesktopGL
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (SpriterGame game = new SpriterGame())
            {
                game.Run();
            }
        }
    }
}
