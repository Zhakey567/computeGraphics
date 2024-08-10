using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;

using System.Windows.Forms;
using Render.Shapes;

namespace Render
{
    public partial class MainForm : Form
    {
        public bool Loaded { get; private set; }
        private GLControl glControl = new GLControl();
        public Shape Shape { get; set; } = new Cube();
        
        public MainForm()
        {
            InitializeComponent();
            MinimumSize = Size;
            glControl.Dock = DockStyle.Fill;
            glControl.BackColor = Color.Black;
            glControl.BorderStyle = BorderStyle.FixedSingle;
            glControl.Paint += new PaintEventHandler(glControl_Paint);
            glControl.Resize += new EventHandler(glControl_Resize);
            previewGroupBox.Controls.Add(glControl);

            InitShapeSettings();
        }

        private void InitShapeSettings()
        {
            Shape.Scale = new Vector3(100, 100, 100);
            Shape.Location = new Vector3(0, 0, 0);
        }
        
        private void SetupViewport(GLControl glControl)
        {
            float aspectRatio = (float)glControl.Width / (float)glControl.Height; 
            GL.Viewport(0, 0, glControl.Width, glControl.Height); 
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity(); 
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, 
                                                                        aspectRatio, 
                                                                        1f,
                                                                        5000000000); 
            GL.MultMatrix(ref perspective); 
            GL.MatrixMode(MatrixMode.Modelview); 
            GL.LoadIdentity();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupViewport(glControl);
            Loaded = true;
        }

        private void glControl_Resize(object sender, EventArgs e) 
        { 
            if (!Loaded) 
                return; 
            SetupViewport(glControl); 
        }

        [Obsolete]
        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (!Loaded) return;
            GL.ClearColor(0.29f, 0.43f, 0.9f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            var modelView = Matrix4.LookAt(new Vector3(-300, 300, 200), 
                new Vector3(0, 0, 0), 
                new Vector3(0, 0, 1));
            
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);
            DrawGizmos();
            Shape.Draw();
            glControl.SwapBuffers();
        }

        [Obsolete("Obsolete")]
        private void DrawGizmos()
        {
            var clr1 = new Vector3(1.0f, 1.0f, 0.0f);
            var clr2 = new Vector3(1.0f, 0.0f, 0.0f);
            var clr3 = new Vector3(0.2f, 0.9f, 1.0f);
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr1);
            GL.Vertex3(-300.0f, 0.0f, 0.0f);
            GL.Vertex3(300.0f, 0.0f, 0.0f);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr2);
            GL.Vertex3(0.0f, -300.0f, 0.0f);
            GL.Vertex3(0.0f, 300.0f, 0.0f);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr3);
            GL.Vertex3(0.0f, 0.0f, -300f);
            GL.Vertex3(0.0f, 0.0f, 300.0f);
            GL.End();
        }
        
        private void applyButton_Click(object sender, EventArgs e)
        {
            Shape.Location = new Vector3 (
                (float)xLocationNumericUpDown.Value,
                (float)yLocationNumericUpDown.Value,
                (float)zLocationNumericUpDown.Value
            );
            Shape.Rotation = new Vector3 (
                (float)xRotationNumericUpDown.Value,
                (float)yRotationNumericUpDown.Value,
                (float)zRotationNumericUpDown.Value
            );
            Shape.Scale = new Vector3 (
                (float)xScaleNumericUpDown.Value,
                (float)yScaleNumericUpDown.Value,
                (float)zScaleNumericUpDown.Value
            );
            
            glControl.Invalidate();
        }

        private void resetLocationButton_Click(object sender, EventArgs e)
        {
            var s = new Shape();
            var location = s.Location;
            xLocationNumericUpDown.Value = (decimal)location.X;
            yLocationNumericUpDown.Value = (decimal)location.Y;
            zLocationNumericUpDown.Value = (decimal)location.Z;
            applyButton_Click(null, EventArgs.Empty);
        }
        
        private void resetRotationButton_Click(object sender, EventArgs e)
        {
            var s = new Shape();
            var rotation = s.Rotation;
            xRotationNumericUpDown.Value = (decimal)rotation.X;
            yRotationNumericUpDown.Value = (decimal)rotation.Y;
            zRotationNumericUpDown.Value = (decimal)rotation.Z;
            applyButton_Click(null, EventArgs.Empty);
        }
        
        private void resetScaleButton_Click(object sender, EventArgs e)
        {
            var s = new Shape();
            var scale = s.Scale;
            xScaleNumericUpDown.Value = (decimal)scale.X * 100;
            yScaleNumericUpDown.Value = (decimal)scale.Y * 100;
            zScaleNumericUpDown.Value = (decimal)scale.Z * 100;
            applyButton_Click(null, EventArgs.Empty);
        }
        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.A || keyData == Keys.D)
            {
                zRotationNumericUpDown.Value = (decimal)(Shape.Rotation.Z + (keyData == Keys.A ? 10 : -10)) % 360;
                applyButton_Click(null, EventArgs.Empty);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            Shape = new Cube();
            InitShapeSettings();
        }

        private void cuboidButton_Click(object sender, EventArgs e)
        {
            Shape = new Cube(1, 0.3f, 0.6f);
            InitShapeSettings();
        }

        private void frustumButton_Click(object sender, EventArgs e)
        {
            Shape = new Cube(new Vector2(0.6f, 1.2f));
            InitShapeSettings();
        }

        private void coneButton_Click(object sender, EventArgs e)
        {
            Shape = new Cone(30);
            InitShapeSettings();
        }

        private void pyramid8Button_Click(object sender, EventArgs e)
        {
            Shape = new Cone(8);
            InitShapeSettings();
        }

        private void pyramid4Button_Click(object sender, EventArgs e)
        {
            Shape = new Cone(4);
            InitShapeSettings();
        }

        private void octahedronButton_Click(object sender, EventArgs e)
        {
            Shape = new Octahedron();
            InitShapeSettings();
        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {
            Shape = new Сylinder(20);
            InitShapeSettings();
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            Shape = new Sphere();
            InitShapeSettings();
        }

        private void torusButton_Click(object sender, EventArgs e)
        {
            Shape = new Torus();
            InitShapeSettings();
        }

        private void helixButton_Click(object sender, EventArgs e)
        {
            Shape = new Helix();
            InitShapeSettings();
        }
    }
}
