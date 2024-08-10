using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Sphere : Shape
    {
        public uint XSubdivide { get; set; }
        public uint YSubdivide { get; set; }
        public float Radius { get; set; }

        private int StacksCount => (int)(4 * YSubdivide);
        private int SlicesCount => (int)(4 * XSubdivide);
        
        public Sphere(float radius = 1f, uint xSubdivide = 10, uint ySubdivide = 10)
        {
            XSubdivide = xSubdivide;
            YSubdivide = ySubdivide;
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
            
            Vertices.Add(new Vector3(0, Radius, 0));

            // generate vertices per stack / slice
            for (var i = 0; i < StacksCount - 1; i++)
            {
                var phi = (float)Math.PI * (i + 1) / StacksCount;
                for (var j = 0; j < SlicesCount; j++)
                {
                    var theta = 2.0 * (float)Math.PI * j / SlicesCount;
                    var x = Radius * (float)Math.Sin(phi) * (float)Math.Cos(theta);
                    var y = Radius * (float)Math.Cos(phi);
                    var z = Radius * (float)Math.Sin(phi) * (float)Math.Sin(theta);
                    Vertices.Add(new Vector3(x, y, z));
                }
            }

            Vertices.Add(new Vector3(0, -Radius, 0));
        }
        
        private void GenerateIndices()
        {
            // add top / bottom triangles
            for (var i = 0; i < SlicesCount; ++i)
            {
                var i0 = i + 1;
                var i1 = (i + 1) % SlicesCount + 1;
                Indices.Add(0);
                Indices.Add(i1);
                Indices.Add(i0);

                i0 = i + SlicesCount * (StacksCount - 2) + 1;
                i1 = (i + 1) % SlicesCount + SlicesCount * (StacksCount - 2) + 1;
                
                Indices.Add(Vertices.Count - 1);
                Indices.Add(i0);
                Indices.Add(i1);
            }

            // add quads per stack / slice
            for (var j = 0; j < StacksCount - 2; j++)
            {
                var j0 = j * SlicesCount + 1;
                var j1 = (j + 1) * SlicesCount + 1;
                for (var i = 0; i < SlicesCount; i++)
                {
                    var i0 = j0 + i;
                    var i1 = j0 + (i + 1) % SlicesCount;
                    var i2 = j1 + (i + 1) % SlicesCount;
                    var i3 = j1 + i;
                    
                    Indices.Add(i0);
                    Indices.Add(i1);
                    Indices.Add(i2);
                    
                    Indices.Add(i0);
                    Indices.Add(i3);
                    Indices.Add(i2);
                }
            }
        }
    }
}