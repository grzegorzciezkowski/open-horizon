using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Settings
{
    public enum ControlAction
    {
        ACCELERATE, DECELERATE, PULL_UP, PULL_DOWN, TURN_LEFT, TURN_RIGHT
    }

    [System.Serializable]
    public class ControlsSettings
    {
        public KeyCode Accelerate = KeyCode.UpArrow;
        public KeyCode Decelerate = KeyCode.DownArrow;
        public KeyCode PullUp = KeyCode.S;
        public KeyCode PullDown = KeyCode.W;
        public KeyCode TurnLeft = KeyCode.A;
        public KeyCode TurnRight = KeyCode.D;
    }
}
