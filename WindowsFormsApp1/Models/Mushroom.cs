﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Mushroom : NPC
    {
        public Mushroom(Game game,int x, int y) : base(game)
        {
            this.img = Properties.Resources.mushroom_prepare;
            this.x = x;
            this.y = y;
            scoreHit = 2;
        }

        public override void Hide()
        {
            isShowing = false;
            Debug.WriteLine("Mushroom is hiding");
        }

        public override void Show()
        {
            isShowing = true;
            Debug.WriteLine("Mushroom is showing");
        }

        public override void isAtacked()
        {
            game.score = game.score + scoreHit;
        }
    }
}
