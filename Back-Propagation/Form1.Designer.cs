using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Back_Propagation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.trainNeuralNetwork = new System.Windows.Forms.Button();
            this.neuralNetworkOutput = new System.Windows.Forms.RichTextBox();
            this.inputBox1 = new System.Windows.Forms.RichTextBox();
            this.inputBox2 = new System.Windows.Forms.RichTextBox();
            this.inputBox3 = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.createNeuralNetwork = new System.Windows.Forms.Button();
            this.testNeuralNetwork = new System.Windows.Forms.Button();
            this.inputBox4 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // trainNeuralNetwork
            // 
            this.trainNeuralNetwork.Location = new System.Drawing.Point(494, 117);
            this.trainNeuralNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.trainNeuralNetwork.Name = "trainNeuralNetwork";
            this.trainNeuralNetwork.Size = new System.Drawing.Size(164, 64);
            this.trainNeuralNetwork.TabIndex = 0;
            this.trainNeuralNetwork.Text = "Train";
            this.trainNeuralNetwork.UseVisualStyleBackColor = true;
            this.trainNeuralNetwork.Click += new System.EventHandler(this.trainNeuralNetwork_Click);
            // 
            // neuralNetworkOutput
            // 
            this.neuralNetworkOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.neuralNetworkOutput.Location = new System.Drawing.Point(494, 42);
            this.neuralNetworkOutput.Margin = new System.Windows.Forms.Padding(4);
            this.neuralNetworkOutput.Name = "neuralNetworkOutput";
            this.neuralNetworkOutput.ReadOnly = true;
            this.neuralNetworkOutput.Size = new System.Drawing.Size(331, 67);
            this.neuralNetworkOutput.TabIndex = 1;
            this.neuralNetworkOutput.Text = "";
            // 
            // inputBox1
            // 
            this.inputBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox1.Location = new System.Drawing.Point(61, 42);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox1.Multiline = false;
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(163, 53);
            this.inputBox1.TabIndex = 2;
            this.inputBox1.Text = "";
            // 
            // inputBox2
            // 
            this.inputBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox2.Location = new System.Drawing.Point(233, 42);
            this.inputBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox2.Multiline = false;
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(163, 54);
            this.inputBox2.TabIndex = 3;
            this.inputBox2.Text = "";
            // 
            // inputBox3
            // 
            this.inputBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox3.Location = new System.Drawing.Point(62, 103);
            this.inputBox3.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox3.Multiline = false;
            this.inputBox3.Name = "inputBox3";
            this.inputBox3.Size = new System.Drawing.Size(163, 51);
            this.inputBox3.TabIndex = 4;
            this.inputBox3.Text = "";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(60, 162);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(336, 60);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // createNeuralNetwork
            // 
            this.createNeuralNetwork.Location = new System.Drawing.Point(494, 189);
            this.createNeuralNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.createNeuralNetwork.Name = "createNeuralNetwork";
            this.createNeuralNetwork.Size = new System.Drawing.Size(331, 63);
            this.createNeuralNetwork.TabIndex = 6;
            this.createNeuralNetwork.Text = "Create Neural Network";
            this.createNeuralNetwork.UseVisualStyleBackColor = true;
            this.createNeuralNetwork.Click += new System.EventHandler(this.createNeuralNetwork_Click);
            // 
            // testNeuralNetwork
            // 
            this.testNeuralNetwork.Location = new System.Drawing.Point(678, 117);
            this.testNeuralNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.testNeuralNetwork.Name = "testNeuralNetwork";
            this.testNeuralNetwork.Size = new System.Drawing.Size(147, 64);
            this.testNeuralNetwork.TabIndex = 7;
            this.testNeuralNetwork.Text = "Test";
            this.testNeuralNetwork.UseVisualStyleBackColor = true;
            this.testNeuralNetwork.Click += new System.EventHandler(this.testNeuralNetwork_Click);
            // 
            // inputBox4
            // 
            this.inputBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.inputBox4.Location = new System.Drawing.Point(233, 103);
            this.inputBox4.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox4.Multiline = false;
            this.inputBox4.Name = "inputBox4";
            this.inputBox4.Size = new System.Drawing.Size(163, 48);
            this.inputBox4.TabIndex = 8;
            this.inputBox4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.inputBox4);
            this.Controls.Add(this.testNeuralNetwork);
            this.Controls.Add(this.createNeuralNetwork);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.inputBox3);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.neuralNetworkOutput);
            this.Controls.Add(this.trainNeuralNetwork);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Neural Network Trainer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button trainNeuralNetwork;
        private RichTextBox neuralNetworkOutput;
        private RichTextBox inputBox1;
        private RichTextBox inputBox2;
        private RichTextBox inputBox3;
        private Button reset;
        private Button createNeuralNetwork;
        private Button testNeuralNetwork;
        private RichTextBox inputBox4;
    }
}