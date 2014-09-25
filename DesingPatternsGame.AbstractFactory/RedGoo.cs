﻿using DesingPatternsGame.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.AbstractFactory
{
    public class RedGoo : GameSprite
    {
        public RedGoo(Texture2D spriteTexture, Vector2 spritePosition)
            : base(spriteTexture, spritePosition)
        {
            Animation = new Animation(100, 48, 48, 27);
        }
    }
}
