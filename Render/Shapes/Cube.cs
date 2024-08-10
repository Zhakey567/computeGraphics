using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;

namespace Render.Shapes
{
    public class Cube : Сylinder
    {
        public Cube(float width = 1f, float height = 1f, float depth = 1f) 
            : base(4, 1 / (float)Math.Sqrt(2), 1 / (float)Math.Sqrt(2))
        {
            ProcessMesh(Matrix3.CreateRotationZ(MathHelper.DegreesToRadians(45)));
            ProcessMesh(Matrix3.CreateScale(width, height, depth));
        }
        
        public Cube(Vector2 topAndBottomSize) 
            : base(
                4, 
                topAndBottomSize.X, 
                topAndBottomSize.Y)
        {
            ProcessMesh(Matrix3.CreateRotationZ(MathHelper.DegreesToRadians(45)));
        }

        private void ProcessMesh(Matrix3 matrixToApply)
        {
            for (var i = 0; i < Vertices.Count; i++)
                Vertices[i] *= matrixToApply;
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