// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeToolStrip();
//       InitializeToolStrip();
//     }

//     private void InitializeToolStrip()
//     {
//       ToolStrip toolStrip = new ToolStrip();

//       ToolStripButton tool1 = new ToolStripButton("□")
//       {
//         ToolTipText = "Tool 1",
//         DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
//       };

//       ToolStripButton tool2 = new ToolStripButton("€")
//       {
//         ToolTipText = "Tool 2",
//         DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
//       };

//       ToolStripButton tool3 = new ToolStripButton("£")
//       {
//         ToolTipText = "Tool 3",
//         DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
//       };

//       ToolStripButton tool4 = new ToolStripButton("¥")
//       {
//         ToolTipText = "Tool 4",
//         DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
//       };

//       ToolStripButton tool5 = new ToolStripButton("©")
//       {
//         ToolTipText = "Tool 5",
//         DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
//       };

//       toolStrip.Items.Add(tool1);
//       toolStrip.Items.Add(tool2);
//       toolStrip.Items.Add(tool3);
//       toolStrip.Items.Add(tool4);
//       toolStrip.Items.Add(tool5);

//       this.Controls.Add(toolStrip);
//       toolStrip.Dock = DockStyle.Top;
//     }
//   }
// }