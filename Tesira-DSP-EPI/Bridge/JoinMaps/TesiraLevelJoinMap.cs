﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharp.Reflection;
using PepperDash.Essentials.Core;


namespace Tesira_DSP_EPI.Bridge.JoinMaps {
    public class TesiraLevelJoinMap : JoinMapBase {
        
        public uint MuteToggle { get; set; }
        public uint MuteOn { get; set; }
        public uint MuteOff { get; set; }
        public uint Volume { get; set; }
        public uint MuteToggleFb { get; set; }
        public uint MuteOnFb { get; set; }
        public uint MuteOffFb { get; set; }
        public uint VolumeFb { get; set; }
        public uint Type { get; set; }
        public uint Label { get; set; }
        public uint VolumeUp { get; set; }
        public uint VolumeDown { get; set; }
        public uint Status { get; set; }
        public uint Permissions { get; set; }
        public uint Visible { get; set; }


        public TesiraLevelJoinMap(uint JoinStart) {

            //These Are Arrays - They all start at Join + IndexOfFader/Mute

            //Digital
            MuteToggle = 400;
            MuteToggleFb = 400;
            MuteOn = 600;
            MuteOnFb = 600;
            MuteOff = 800;
            MuteOffFb = 800;
            VolumeUp = 1000;
            VolumeDown = 1200;
            Visible = 200;

            //Analog
            Volume = 200;
            VolumeFb = 200;
            Type = 400;
            Status = 600;
            Permissions = 800;

            //Serial
            Label = 200;

            OffsetJoinNumbers(JoinStart);

        }


        public override void OffsetJoinNumbers(uint joinStart) {
            var joinOffset = joinStart - 1;

            MuteToggle += joinOffset;
            MuteToggleFb += joinOffset;
            MuteOn += joinOffset;
            MuteOnFb += joinOffset;
            MuteOff += joinOffset;
            MuteOffFb += joinOffset;
            VolumeUp += joinOffset;
            VolumeDown += joinOffset;
            Visible += joinOffset;

            Volume += joinOffset;
            VolumeFb += joinOffset;
            Type += joinOffset;
            Status += joinOffset;
            Permissions += joinOffset;
            Label += joinOffset;
        }


        

    }
}