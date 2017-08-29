﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SoftwareRenderingEngine.Math3D;

namespace SoftwareRenderingEngine.RenderStruct {

    public class Vertex {

        //顶点坐标
        public Vector3 position;

        //顶点法线
        public Vector3 normal;

        //顶点纹理坐标
        public float u, v;

        //顶点颜色
        public Color color;

        public Vertex() {
            position = new Vector3();
            normal = new Vector3();
            u = v = 0;
            color = new Color();
        }

    }
}
