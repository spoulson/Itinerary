using System;
using System.Linq;
using System.Windows.Forms;
using Expl.Itinerary;
using Expl.Itinerary.Parser;
using System.Collections.Generic;

namespace TDL_Explorer {
   public partial class Form1 : Form {
      private IEnumerable<TimedEvent> parsedEvents;
      private IDictionary<string, bool> tabPopulateFlags = new Dictionary<string, bool>();

      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         textBox_StartRange.Text = DateTime.Now.Date.ToString();
         textBox_EndRange.Text = DateTime.Now.Date.AddDays(100).ToString();

         // Populate Insert Example dropdown menu.
         PopulateExamplesMenu();
      }

      private void PopulateExamplesMenu() {
         insertExamplesToolStripDropDownButton.DropDownItems.Clear();

         // Recursive procedure for traversing IExampleItem tree.
         Action<ToolStripDropDownItem, IExampleItem> funcAddExampleItem = null;
         funcAddExampleItem = new Action<ToolStripDropDownItem, IExampleItem>((menu, exampleItem) => {
            ToolStripMenuItem newMenu = null;

            if (exampleItem is ExampleSchedule) {
               // Add schedule item.
               var exampleSchedule = (ExampleSchedule)exampleItem;
               newMenu = new ToolStripMenuItem(exampleSchedule.Name, null,
                  new EventHandler((a, b) => InsertTDL(exampleSchedule.Schedule.ToString())));
            }
            else if (exampleItem is ExampleGroup) {
               // Add group item.
               var exampleGroup = (ExampleGroup)exampleItem;
               newMenu = new ToolStripMenuItem(exampleGroup.Name, null);

               // Recurse into ExampleGroup items to populate the new menu item.
               foreach (var subItem in exampleGroup.Items) {
                  funcAddExampleItem(newMenu, subItem);
               }
            }

            // Attach the new menu item to the menu.
            menu.DropDownItems.Add(newMenu);
         });

         foreach (var item in Examples.ExampleList) {
            funcAddExampleItem(insertExamplesToolStripDropDownButton, item);
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
      /// Handle tab page change.
      /// Ensure tab page is populated.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
         PopulateCurrentTab();
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
            // Parse TDL.
            var sched = TDLParser.Parse(textBox_TDL.Text);

            parsedEvents = sched.GetRange(StartRange, EndRange)
               .Take(10000);

            // Clear tab page populate flags.
            tabPopulateFlags.Clear();

            PopulateCurrentTab();

            toolStripStatusLabel1.Text = string.Format("TDL parsed successfully.  Generated {0} events.", parsedEvents.Count());
         }
         catch {
            toolStripStatusLabel1.Text = "Error parsing TDL.";
            return;
         }
      }

      /// <summary>
      /// Populate the currently visible tab page.
      /// Mark tab page as populated so that it is not repopulated again until TDL is reparsed.
      /// </summary>
      private void PopulateCurrentTab() {
         var tabName = tabControl1.SelectedTab.Name;

         // Check if tab is already populated since last parse.
         if (tabPopulateFlags.Keys.Contains(tabName) && tabPopulateFlags[tabName]) return;

         switch (tabName) {
         case "eventListTabPage":
            // Populate datagrid view.
            var eventTexts =
               parsedEvents.Select(te => new {
                  StartTime = ItineraryConvert.ToString(te.StartTime),
                  EndTime = ItineraryConvert.ToString(te.EndTime),
                  Duration = te.Duration.ToString()
               })
               .ToArray();
            dataGridView_TimedEvents.SuspendLayout();
            dataGridView_TimedEvents.DataSource = eventTexts;
            dataGridView_TimedEvents.Columns[0].Width = 150;
            dataGridView_TimedEvents.Columns[1].Width = 150;
            dataGridView_TimedEvents.Columns[2].Width = 125;
            dataGridView_TimedEvents.ResumeLayout();
            break;

         case "calendarTabPage":
            // Populate calendar view.
            var eventDates = parsedEvents.SelectMany(e => e.GetEventDates()).ToArray();
            monthCalendar_Events.SuspendLayout();
            monthCalendar_Events.BoldedDates = eventDates;
            monthCalendar_Events.ResumeLayout();
            break;

         default:
            break;
         }

         tabPopulateFlags[tabName] = true;
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