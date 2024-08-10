using System.Windows.Forms;

namespace Render.ShapeSettings
{
    public class ConeSettingsTab : TabPage
    {
        public ConeSettingsTab()
        {
            Name = "Cone";
            Text = Name;
            tableLayoutPanel.Dock = DockStyle.Fill;
            for (var i = 0; i < 3; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            for (var i = 0; i < 2; i++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}