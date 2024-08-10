using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Torus : Shape
    {
        public Torus(float majorRadius = 1.5f, int majorSegmentsCount = 20, float minorRadius  = 0.5f, int minorSegmentsCount = 20)
        {
            MajorRadius = majorRadius;
            MajorSegmentsCount = majorSegmentsCount;
            MinorRadius = minorRadius;
            MinorSegmentsCount = minorSegmentsCount;
            Generate();
        }

        public float MajorRadius { get; set; }
        public int MajorSegmentsCount { get; set; }
        public float MinorRadius { get; set; } // Segment radius
        public int MinorSegmentsCount { get; set; }

        [Obsolete("Obsolete")]
        public override void DrawIndexed()
        {
            var colorIndex = 0;
            GL.Begin(BeginMode);
            foreach (var i in Indices)
            {
                GL.Color3(Colors[colorIndex]);
                GL.Vertex3(VertexShader(Vertices[i]));
                colorIndex++;
            }
            GL.End();
        }
        
        private void Generate()
        {
            Vertices = new List<Vector3>();
            Indices = new List<int>();

            var majorSegmentAngleStep = MathHelper.DegreesToRadians(360.0f / MajorSegmentsCount);
            var minorSegmentAngleStep = MathHelper.DegreesToRadians(360.0f / MinorSegmentsCount);

            for (var i = 0; i < MajorSegmentsCount; ++i)
                GenerateSegment(majorSegmentAngleStep * i, minorSegmentAngleStep);

            GenerateIndices();
            GenerateColorsForIndices();
        }

        private void GenerateIndices()
        {
            for (var i = 0; i < MajorSegmentsCount; i++)
            {
                for (var j = 0; j < MinorSegmentsCount; j++)
                {
                    Indices.Add(i % MajorSegmentsCount * MinorSegmentsCount + j % MinorSegmentsCount);
                    Indices.Add(i % MajorSegmentsCount * MinorSegmentsCount + (j + 1) % MinorSegmentsCount);
                    Indices.Add((i + 1) % MajorSegmentsCount * MinorSegmentsCount + (j + 1) % MinorSegmentsCount);
                    
                    Indices.Add(i % MajorSegmentsCount * MinorSegmentsCount + j % MinorSegmentsCount);
                    Indices.Add((i + 1) % MajorSegmentsCount * MinorSegmentsCount + (j + 1) % MinorSegmentsCount);
                    Indices.Add((i + 1) % MajorSegmentsCount * MinorSegmentsCount + j % MinorSegmentsCount);
                }
            }
        }

        private void GenerateSegment(float majorSegmentAngle, float minorSegmentAngleStep)
        {
            var sinMajorSegment = (float)Math.Sin(majorSegmentAngle);
            var cosMajorSegment = (float)Math.Cos(majorSegmentAngle);
            for (var i = 0; i < MinorSegmentsCount; ++i)
            {
                var currentMinorSegmentAngle = i * minorSegmentAngleStep;
                var sinMinorSegment = (float)Math.Sin(currentMinorSegmentAngle);
                var cosMinorSegment = (float)Math.Cos(currentMinorSegmentAngle);

                var vertex = new Vector3(
                    (MajorRadius + MinorRadius * cosMinorSegment) * cosMajorSegment + Location.X,
                    (MajorRadius + MinorRadius * cosMinorSegment) * sinMajorSegment + Location.Y,
                    MinorRadius * sinMinorSegment + Location.Z
                );

                Vertices.Add(vertex);
            }
        }
    }
}