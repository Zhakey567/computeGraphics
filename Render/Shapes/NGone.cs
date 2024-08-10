using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class NGone : Shape
    {
        public uint VertexCount { get; set; }
        public float Radius { get; set; }
        
        public NGone(uint vertexCount, float radius = 1f)
        {
            VertexCount = vertexCount;
            Radius = radius;
            Generate();
        }
        
        public void Generate()
        {
            GenerateVertices();
            GenerateIndices();
            GenerateColorsForIndices();
        }

        private void GenerateVertices()
        {
            Vertices = new List<Vector3>();

            var angleStep = MathHelper.DegreesToRadians(360.0f / VertexCount);
            
            for (var i = 0; i < VertexCount; i ++)
            {
                var angle = angleStep * i;
                var x = Radius * (float)Math.Sin(angle);
                var y = Radius * (float)Math.Cos(angle);
                Vertices.Add(new Vector3(x, y, 0f));
            }
        }
        
        private void GenerateIndices()
        {
            Indices = new List<int>();
            for(var i = 1; i < VertexCount - 1; i++)
            {
                Indices.Add(0);
                Indices.Add(i);
                Indices.Add(i + 1);
            }
        }
    }
}