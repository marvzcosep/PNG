﻿using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public abstract class Player : IPlayer
    {
        private string _name;

        public virtual string Name { get => this._name; set => this._name = value; }
    }
}
