using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Color = System.Drawing.Color;

namespace Render.Shapes
{
    public class Shape
    {
        public List<Vector3> Vertices { get; protected set; } = new List<Vector3>();
        public List<int> Indices { get; protected set; } = new List<int>();
        public List<Color> Colors { get; set; }= new List<Color>();
        public virtual BeginMode BeginMode { get; set; } = BeginMode.Triangles;

        public virtual Vector3 Scale { get; set; } = new Vector3(1f, 1f, 1f);
        public virtual Vector3 Rotation { get; set; } = new Vector3(0f, 0f, 0f);
        public virtual Vector3 Location { get; set; } = new Vector3(0f, 0f, 0f);

        public Color Color { get; set; } = Color.White;

        private static Random random = new Random();
        public static Color RandomColor => Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

        protected virtual void GenerateColorsForIndices()
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

        [Obsolete("Obsolete")]
        public virtual void Draw() => DrawIndexed();
        
        [Obsolete("Obsolete")]
        public virtual void DrawIndexed()
        {
            if (Indices is null || Vertices is null)
                throw new AggregateException("Shape is not generated");

            GL.Begin(BeginMode);
            for (var i = 0; i < Indices.Count; i++)
            {
                GL.Color3(Colors.Count == Indices.Count ? Colors[i] : RandomColor);
                GL.PointSize(10);
                GL.Vertex3(VertexShader(Vertices[Indices[i]]));
            }
            GL.End();
        }

        private static float ToRad(float deg) => deg * (float)Math.PI / 180f;
        private static Vector3 ToRad(Vector3 v) => new Vector3(ToRad(v.X),ToRad(v.Y),ToRad(v.Z));
        
        public virtual Vector3 VertexShader(Vector3 vertex)
        {
            return Matrix3.CreateFromQuaternion(new Quaternion(ToRad(Rotation))) * vertex * Scale + Location;
        }

        protected void AddTriangle(int i1, int i2, int i3)
        {
            Indices.Add(i1);
            Indices.Add(i2);
            Indices.Add(i3);
        }
    }
}
