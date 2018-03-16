using System;   
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WDBChatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI
        private void jsonDeserialize_Click(object sender, EventArgs e)
        {
            //jsonDebugOutput(jsonInput.Text);
            deserializeJson(jsonInput.Text);
        }

        private void jsonClear_Click(object sender, EventArgs e)
        {
            jsonInput.Text = string.Empty;
            jsonOutput.Text = string.Empty;
        }
        #endregion

        #region Deserialization
        private void deserializeJson(string jsonString)
        {
            try
            {
                var jsonParse = JsonConvert.DeserializeObject<JsonClass>(jsonString);
                jsonDebugOutput( jsonParse.ToString());
                jsonDebugOutput(  jsonParse.topScoringIntent.intent.ToString());

                #region Printing all elements in an array or list of Intents
                foreach (var num in jsonParse.intents)
                {
                    jsonDebugOutput("Intent is " + num.intent +" and Score is "+ num.score);
                }
                #endregion

                #region Printing all elements in array of entities
                foreach (var num in jsonParse.entities)
                {
                    jsonDebugOutput("Entity selected is "+num.entity /*+ ", type of entity is " + num.type + " and score is " + num.score*/);
                }
                #endregion

            }
            catch (Exception e)
            {
                jsonDebugOutput("Exception occurred:"+ e.Message.ToString());
            }
        }
        #endregion

        #region Output Textbox Function
        private void jsonDebugOutput(string jsonText)
        {
            System.Diagnostics.Debug.Write(jsonText + Environment.NewLine);
            jsonOutput.Text = jsonOutput.Text + jsonText + Environment.NewLine;
            jsonOutput.SelectionStart = jsonOutput.TextLength;
            jsonOutput.ScrollToCaret();
        }
        #endregion

    }
}
