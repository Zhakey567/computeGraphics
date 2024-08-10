using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Сylinder : Shape
    {
        public float TopRadius { get; }
        public float BottomRadius { get; }
        
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

        public Сylinder(uint vertexCount, float topRadius = 1f, float bottomRadius = 1f)
        {
            VertexCount = vertexCount;
            TopRadius = topRadius;
            BottomRadius = bottomRadius;
		    Generate();
	    }

        public override BeginMode BeginMode => BeginMode.Triangles;
        
        protected virtual void Generate()
        {
            Vertices = new List<Vector3>();
            Indices = new List<int>();
            
            var topPlane = new NGone(VertexCount, TopRadius) { Location = new Vector3(0, 0, 0.5f) };
            var topVertices = topPlane.Vertices.Select(topPlane.VertexShader).ToArray();
            Indices.AddRange(topPlane.Indices);
            
            var bottomPlane = new NGone(VertexCount, BottomRadius) { Location = new Vector3(0, 0, -0.5f) };
            var bottomVertices = bottomPlane.Vertices.Select(bottomPlane.VertexShader).ToArray();
            Vertices = topVertices.Concat(bottomVertices).ToList();
            Indices.AddRange(bottomPlane.Indices.Select(i => i + topPlane.Vertices.Count));

            for (var i = 0; i < vertexCount; i++)
            {
                Indices.Add((int)(i % VertexCount));
                Indices.Add((int)((i + 1) % VertexCount));
                Indices.Add((int)((i + 1) % VertexCount + VertexCount));

                Indices.Add((int)(i % VertexCount));
                Indices.Add((int)((i + 1) % VertexCount + VertexCount));
                Indices.Add((int)(i % VertexCount + VertexCount));
            }

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
