using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectVR
{
    class PlayerProperties
    {
        public bool IsNotMoving;
        public bool IsWalking;
        public bool IsJogging;
        public bool IsSprinting;

        public static PlayerProperties PlayerOne { get; } = new PlayerProperties();
    }
}
