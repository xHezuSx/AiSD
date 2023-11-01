namespace Algortytmy_Sortowania
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBoxInput = new System.Windows.Forms.TextBox();
            this.TxtBoxOutput = new System.Windows.Forms.MaskedTextBox();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnRNG_Start = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfElements = new System.Windows.Forms.NumericUpDown();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBox_RNG_OnOff = new System.Windows.Forms.CheckBox();
            this.labelError1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRNG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfElements)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxInput
            // 
            this.TxtBoxInput.Location = new System.Drawing.Point(40, 50);
            this.TxtBoxInput.Name = "TxtBoxInput";
            this.TxtBoxInput.Size = new System.Drawing.Size(298, 20);
            this.TxtBoxInput.TabIndex = 0;
            // 
            // TxtBoxOutput
            // 
            this.TxtBoxOutput.Location = new System.Drawing.Point(40, 226);
            this.TxtBoxOutput.Name = "TxtBoxOutput";
            this.TxtBoxOutput.ReadOnly = true;
            this.TxtBoxOutput.Size = new System.Drawing.Size(298, 20);
            this.TxtBoxOutput.TabIndex = 1;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(91, 345);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(113, 44);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(210, 345);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(113, 44);
            this.btnSelection.TabIndex = 4;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(448, 345);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(113, 44);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(329, 345);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(113, 44);
            this.btnInsertion.TabIndex = 5;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnRNG_Start
            // 
            this.btnRNG_Start.Location = new System.Drawing.Point(522, 163);
            this.btnRNG_Start.Name = "btnRNG_Start";
            this.btnRNG_Start.Size = new System.Drawing.Size(84, 46);
            this.btnRNG_Start.TabIndex = 8;
            this.btnRNG_Start.Text = "Generuj";
            this.btnRNG_Start.UseVisualStyleBackColor = true;
            this.btnRNG_Start.Click += new System.EventHandler(this.btnRNG_Start_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(567, 345);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(113, 44);
            this.btnQuick.TabIndex = 7;
            this.btnQuick.Text = "Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(456, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Czas:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(518, 241);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(73, 24);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "--:--:--:--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter the integer array";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sorted Array";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "liczba losowych elementów";
            // 
            // numericUpDown_NumOfElements
            // 
            this.numericUpDown_NumOfElements.Location = new System.Drawing.Point(522, 103);
            this.numericUpDown_NumOfElements.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_NumOfElements.Name = "numericUpDown_NumOfElements";
            this.numericUpDown_NumOfElements.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown_NumOfElements.TabIndex = 14;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(37, 73);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 15;
            this.labelError.Visible = false;
            // 
            // checkBox_RNG_OnOff
            // 
            this.checkBox_RNG_OnOff.AutoSize = true;
            this.checkBox_RNG_OnOff.Location = new System.Drawing.Point(507, 50);
            this.checkBox_RNG_OnOff.Name = "checkBox_RNG_OnOff";
            this.checkBox_RNG_OnOff.Size = new System.Drawing.Size(99, 17);
            this.checkBox_RNG_OnOff.TabIndex = 16;
            this.checkBox_RNG_OnOff.Text = "Generuj losowo";
            this.checkBox_RNG_OnOff.UseVisualStyleBackColor = true;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Location = new System.Drawing.Point(56, 87);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(0, 13);
            this.labelError1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "zakres: (0-1000)";
            // 
            // labelRNG
            // 
            this.labelRNG.AutoSize = true;
            this.labelRNG.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelRNG.Location = new System.Drawing.Point(612, 163);
            this.labelRNG.Name = "labelRNG";
            this.labelRNG.Size = new System.Drawing.Size(0, 13);
            this.labelRNG.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRNG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.checkBox_RNG_OnOff);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.numericUpDown_NumOfElements);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRNG_Start);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.TxtBoxOutput);
            this.Controls.Add(this.TxtBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxInput;
        private System.Windows.Forms.MaskedTextBox TxtBoxOutput;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnRNG_Start;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfElements;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBox_RNG_OnOff;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRNG;
    }
}

