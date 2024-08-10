using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Cone : Shape
    {
        public float Radius { get; set; }
        
        private uint vertexCount = 10;
        public uint VertexCount
        {
            get => vertexCount;
            set
            {
                vertexCount = value;
                Generate();
            }
        }

        public Cone(uint vertexCount, float radius = 1f)
        {
            VertexCount = vertexCount;
            Radius = radius;
		    Generate();
	    }

        public override BeginMode BeginMode => BeginMode.Triangles;
        
        protected virtual void Generate()
        {
            Vertices = new List<Vector3>();
            Indices = new List<int>();
            
            Vertices.Add(new Vector3(0, 0, 0.5f)); 
            
            var plane = new NGone(VertexCount, Radius / (float)Math.Sqrt(2)) { Location = new Vector3(0, 0, -0.5f) };
            var vertices = plane.Vertices.Select(plane.VertexShader).ToArray();
            Vertices.AddRange(vertices.Concat(vertices).ToList());
            Indices.AddRange(plane.Indices.Select(i => i + 1));

            for (var i = 1; i < VertexCount; i++)
            {
                Indices.Add(0);
                Indices.Add(i);
                Indices.Add(i + 1);
            }
            Indices.Add(0);
            Indices.Add((int)VertexCount);
            Indices.Add(1);
            GenerateColorsForIndices();
        }

        protected override void GenerateColorsForIndices()
        {
            Colors = new List<Color>();
            var index = 0;
            var color = RandomColor;
            foreach (var _ in Indices)
            {
                if (index++ % 3 == 0)
                    color = RandomColor;
                Colors.Add(color);
            }
        }
    }
}