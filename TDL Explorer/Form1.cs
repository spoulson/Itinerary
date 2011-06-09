using System;
using System.Linq;
using System.Windows.Forms;
using Expl.Itinerary;
using Expl.Itinerary.Parser;

namespace TDL_Explorer {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         textBox_StartRange.Text = DateTime.Now.Date.ToString();
         textBox_EndRange.Text = DateTime.Now.Date.AddDays(1).ToString();

         // Get examples, populate menu.
         insertExamplesToolStripDropDownButton.DropDownItems.Clear();
         var ExampleMenuItems = Examples.GetExampleList()
            .Select(x => new ToolStripMenuItem(x.Name, null, new EventHandler((a, b) => InsertTDL(x.Schedule.ToString()))));
         foreach (var item in ExampleMenuItems) {
            insertExamplesToolStripDropDownButton.DropDownItems.Add(item);
         }
      }

      private void toolStripButton_Parse_Click(object sender, EventArgs e) {
         ParseTDL();
      }

      private void textBox_TDL_KeyDown(object sender, KeyEventArgs e) {
         if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A) {
            // Ctrl+A: Select all
            SelectAllTDL();
         }
         else if (e.KeyData == Keys.F5) {
            // F5: Parse
            ParseTDL();
         }
      }

      /// <summary>
      /// Parse user input TDL and date range.
      /// Populate datagrid with generated TimedEvents.
      /// </summary>
      private void ParseTDL() {
         ClearAll();

         DateTime StartRange = DateTime.MinValue, EndRange = DateTime.MinValue;
         try {
            StartRange = DateTime.Parse(textBox_StartRange.Text);
         }
         catch {
            toolStripStatusLabel1.Text = "Error parsing StartRange datetime.";
            return;
         }

         try {
            EndRange = DateTime.Parse(textBox_EndRange.Text);
         }
         catch {
            toolStripStatusLabel1.Text = "Error parsing EndRange datetime.";
            return;
         }

         try {
            var sched = TDLParser.Parse(textBox_TDL.Text);
            var events = sched.GetRange(StartRange, EndRange)
               .Take(10000)
               .Select(te => new {
                  StartTime = ItineraryConvert.ToString(te.StartTime),
                  EndTime = ItineraryConvert.ToString(te.EndTime),
                  Duration = te.Duration.ToString()
               })
               .ToArray();

            dataGridView_TimedEvents.SuspendLayout();
            dataGridView_TimedEvents.DataSource = events;
            dataGridView_TimedEvents.Columns[0].Width = 150;
            dataGridView_TimedEvents.Columns[1].Width = 150;
            dataGridView_TimedEvents.Columns[2].Width = 125;
            dataGridView_TimedEvents.ResumeLayout();
            
            toolStripStatusLabel1.Text = string.Format("TDL parsed successfully.  Generated {0} events.", events.Count());
         }
         catch {
            toolStripStatusLabel1.Text = "Error parsing TDL.";
            return;
         }

      }

      /// <summary>
      /// Clear program state.
      /// </summary>
      private void ClearAll() {
         dataGridView_TimedEvents.DataSource = null;
         toolStripStatusLabel1.Text = "";
      }

      /// <summary>
      /// Insert text in TDL field at the cursor.
      /// </summary>
      /// <param name="text"></param>
      private void InsertTDL(string text) {
         string userText = textBox_TDL.Text;
         int idx = textBox_TDL.SelectionStart;

         if (textBox_TDL.SelectionLength > 0) {
            // Delete selected text
            userText = userText.Remove(textBox_TDL.SelectionStart, textBox_TDL.SelectionLength);
         }

         textBox_TDL.Text = userText.Insert(idx, text);
         textBox_TDL.SelectionStart = idx + text.Length;
      }

      /// <summary>
      /// Select all text in TDL field.
      /// </summary>
      private void SelectAllTDL() {
         textBox_TDL.SelectionStart = 0;
         textBox_TDL.SelectionLength = textBox_TDL.Text.Length;
      }
   }
}