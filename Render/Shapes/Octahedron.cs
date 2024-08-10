using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Octahedron : Shape
    {
        public float Radius { get; set; }
        
        public Octahedron(float radius = 1f)
        {
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
            // Top
            Vertices.Add(new Vector3(0, 0, Radius));
            // Middle
            var plane = new NGone(4, Radius);
            Vertices.AddRange(plane.Vertices);
            // Bottom
            Vertices.Add(new Vector3(0, 0, -Radius));
        }
        
        private void GenerateIndices()
        {
            foreach (var v in new List<int> { 0, Vertices.Count - 1 })
            {
                for (var i = 1; i < Vertices.Count - 1; i++)
                {
                    var next = (i + 1) % (Vertices.Count - 1);
                    if (next == 0)
                        next++;
                    AddTriangle(v, i, next);
                }
            }
        }
    }
}