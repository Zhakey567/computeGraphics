using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Render.Shapes
{
    public class Helix : Shape
    {
        public Helix(
            int arcCount = 4,
            float arcLength = 0.5f,
            float majorRadius = 0.5f, 
            int majorSegmentsCount = 50, 
            float minorRadius  = 0.15f, 
            int minorSegmentsCount = 20)
        {
            ArcCount = arcCount;
            ArcLength = arcLength;
            MajorRadius = majorRadius;
            MajorSegmentsCount = majorSegmentsCount;
            MinorRadius = minorRadius;
            MinorSegmentsCount = minorSegmentsCount;
            Generate();
        }
        
        public float ArcLength { get; set; }
        public int ArcCount { get; set; }
        
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

            var majorSegmentAngleStep = 360.0f / MajorSegmentsCount;
            var segmentsCount = MajorSegmentsCount * ArcCount;
            for (var i = - segmentsCount / 2; i < segmentsCount / 2; i++)
            {
                var angle = MathHelper.DegreesToRadians(i * majorSegmentAngleStep);
                var x = (float)Math.Cos(angle) * MajorRadius - MajorRadius / 2;
                var y = (float)Math.Sin(angle) * MajorRadius - MajorRadius / 2;
                GenerateSegment(angle, new Vector3(x, y, ArcLength / MajorSegmentsCount * i));
            }

            GenerateIndices();

            GenerateColorsForIndices();
        }

        private void GenerateIndices()
        {
            for (var i = 0; i < (MajorSegmentsCount - 1) * ArcCount; i++)
            {
                for (var j = 0; j < MinorSegmentsCount; j++)
                {
                    var i0 = i % (MajorSegmentsCount * ArcCount) * MinorSegmentsCount + j % MinorSegmentsCount;
                    var i1 = i % (MajorSegmentsCount * ArcCount) * MinorSegmentsCount + (j + 1) % MinorSegmentsCount;
                    var i2 = (i + 1) % (MajorSegmentsCount * ArcCount) * MinorSegmentsCount + (j + 1) % MinorSegmentsCount;
                    var i3 = (i + 1) % (MajorSegmentsCount * ArcCount) * MinorSegmentsCount + j % MinorSegmentsCount;
                    
                    Indices.Add(i0);
                    Indices.Add(i1);
                    Indices.Add(i2);
                    
                    Indices.Add(i0);
                    Indices.Add(i2);
                    Indices.Add(i3);
                }
            }
        }

        private void GenerateSegment(float majorSegmentAngle, Vector3 location)
        {
            var minorSegmentAngleStep = MathHelper.DegreesToRadians(360.0f / MinorSegmentsCount);
            
            var sinMajorSegment = (float)Math.Sin(majorSegmentAngle);
            var cosMajorSegment = (float)Math.Cos(majorSegmentAngle);
            for (var i = 0; i < MinorSegmentsCount; ++i)
            {
                var currentMinorSegmentAngle = i * minorSegmentAngleStep;
                var sinMinorSegment = (float)Math.Sin(currentMinorSegmentAngle);
                var cosMinorSegment = (float)Math.Cos(currentMinorSegmentAngle);

                var vertex = new Vector3(
                    (MajorRadius + MinorRadius * cosMinorSegment) * cosMajorSegment,
                    (MajorRadius + MinorRadius * cosMinorSegment) * sinMajorSegment,
                    MinorRadius * sinMinorSegment + location.Z
                );
                    
                Vertices.Add(vertex);
            }
        }
    }
}