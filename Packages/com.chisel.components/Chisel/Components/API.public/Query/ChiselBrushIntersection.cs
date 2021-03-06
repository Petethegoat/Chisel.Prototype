﻿using Chisel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Vector2	 = UnityEngine.Vector2;
using Vector3	 = UnityEngine.Vector3;
using Vector4	 = UnityEngine.Vector4;
using GameObject = UnityEngine.GameObject;
using Camera	 = UnityEngine.Camera;
using Plane		 = UnityEngine.Plane;
using System.Runtime.InteropServices;

namespace Chisel.Components
{
    public class ChiselBrushIntersection
    {
        public ChiselNode		        node;
        public CSGTreeBrushIntersection intersection;
    };
}
