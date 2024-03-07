namespace Roguelite_Text_Game
{
    partial class GameEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EventSelectButton = new System.Windows.Forms.Button();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TagsToAddTextBox = new System.Windows.Forms.TextBox();
            this.ValidTagsTextBox = new System.Windows.Forms.TextBox();
            this.ValidStagesTextBox = new System.Windows.Forms.TextBox();
            this.MinRollTextBox = new System.Windows.Forms.TextBox();
            this.MaxRollTextBox = new System.Windows.Forms.TextBox();
            this.LifespanEffectTextBox = new System.Windows.Forms.TextBox();
            this.AgeEffectTextBox = new System.Windows.Forms.TextBox();
            this.ProgressEffectTextBox = new System.Windows.Forms.TextBox();
            this.TalentEffectTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.EventDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveEventFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.StagesListBox = new System.Windows.Forms.ListBox();
            this.StageFileSelectButton = new System.Windows.Forms.Button();
            this.SaveStageFileButton = new System.Windows.Forms.Button();
            this.AddStageButton = new System.Windows.Forms.Button();
            this.RemoveEventButton = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.StageNameTextBox = new System.Windows.Forms.TextBox();
            this.LifeSpanTextBox = new System.Windows.Forms.TextBox();
            this.GoalTextBox = new System.Windows.Forms.TextBox();
            this.StageUpButton = new System.Windows.Forms.Button();
            this.StageDownButton = new System.Windows.Forms.Button();
            this.RemoveStageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EventSelectButton
            // 
            this.EventSelectButton.Location = new System.Drawing.Point(12, 310);
            this.EventSelectButton.Name = "EventSelectButton";
            this.EventSelectButton.Size = new System.Drawing.Size(177, 23);
            this.EventSelectButton.TabIndex = 0;
            this.EventSelectButton.Text = "Select Event File";
            this.EventSelectButton.UseVisualStyleBackColor = true;
            this.EventSelectButton.Click += new System.EventHandler(this.EventSelectButton_Click);
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.Location = new System.Drawing.Point(12, 12);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(177, 290);
            this.EventListBox.TabIndex = 1;
            this.EventListBox.SelectedIndexChanged += new System.EventHandler(this.EventListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TagsToAddTextBox);
            this.groupBox1.Controls.Add(this.ValidTagsTextBox);
            this.groupBox1.Controls.Add(this.ValidStagesTextBox);
            this.groupBox1.Controls.Add(this.MinRollTextBox);
            this.groupBox1.Controls.Add(this.MaxRollTextBox);
            this.groupBox1.Controls.Add(this.LifespanEffectTextBox);
            this.groupBox1.Controls.Add(this.AgeEffectTextBox);
            this.groupBox1.Controls.Add(this.ProgressEffectTextBox);
            this.groupBox1.Controls.Add(this.TalentEffectTextBox);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.EventDescriptionTextBox);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // TagsToAddTextBox
            // 
            this.TagsToAddTextBox.Location = new System.Drawing.Point(113, 254);
            this.TagsToAddTextBox.Name = "TagsToAddTextBox";
            this.TagsToAddTextBox.Size = new System.Drawing.Size(141, 20);
            this.TagsToAddTextBox.TabIndex = 21;
            this.TagsToAddTextBox.TextChanged += new System.EventHandler(this.TagsToAddTextBox_TextChanged);
            // 
            // ValidTagsTextBox
            // 
            this.ValidTagsTextBox.Location = new System.Drawing.Point(113, 228);
            this.ValidTagsTextBox.Name = "ValidTagsTextBox";
            this.ValidTagsTextBox.Size = new System.Drawing.Size(141, 20);
            this.ValidTagsTextBox.TabIndex = 20;
            this.ValidTagsTextBox.TextChanged += new System.EventHandler(this.ValidTagsTextBox_TextChanged);
            // 
            // ValidStagesTextBox
            // 
            this.ValidStagesTextBox.Location = new System.Drawing.Point(113, 202);
            this.ValidStagesTextBox.Name = "ValidStagesTextBox";
            this.ValidStagesTextBox.Size = new System.Drawing.Size(141, 20);
            this.ValidStagesTextBox.TabIndex = 19;
            this.ValidStagesTextBox.TextChanged += new System.EventHandler(this.ValidStagesTextBox_TextChanged);
            // 
            // MinRollTextBox
            // 
            this.MinRollTextBox.Location = new System.Drawing.Point(113, 176);
            this.MinRollTextBox.Name = "MinRollTextBox";
            this.MinRollTextBox.Size = new System.Drawing.Size(141, 20);
            this.MinRollTextBox.TabIndex = 18;
            this.MinRollTextBox.TextChanged += new System.EventHandler(this.MinRollTextBox_TextChanged);
            // 
            // MaxRollTextBox
            // 
            this.MaxRollTextBox.Location = new System.Drawing.Point(113, 150);
            this.MaxRollTextBox.Name = "MaxRollTextBox";
            this.MaxRollTextBox.Size = new System.Drawing.Size(141, 20);
            this.MaxRollTextBox.TabIndex = 17;
            this.MaxRollTextBox.TextChanged += new System.EventHandler(this.MaxRollTextBox_TextChanged);
            // 
            // LifespanEffectTextBox
            // 
            this.LifespanEffectTextBox.Location = new System.Drawing.Point(113, 124);
            this.LifespanEffectTextBox.Name = "LifespanEffectTextBox";
            this.LifespanEffectTextBox.Size = new System.Drawing.Size(141, 20);
            this.LifespanEffectTextBox.TabIndex = 16;
            this.LifespanEffectTextBox.TextChanged += new System.EventHandler(this.LifespanEffectTextBox_TextChanged);
            // 
            // AgeEffectTextBox
            // 
            this.AgeEffectTextBox.Location = new System.Drawing.Point(113, 98);
            this.AgeEffectTextBox.Name = "AgeEffectTextBox";
            this.AgeEffectTextBox.Size = new System.Drawing.Size(141, 20);
            this.AgeEffectTextBox.TabIndex = 15;
            this.AgeEffectTextBox.TextChanged += new System.EventHandler(this.AgeEffectTextBox_TextChanged);
            // 
            // ProgressEffectTextBox
            // 
            this.ProgressEffectTextBox.Location = new System.Drawing.Point(113, 72);
            this.ProgressEffectTextBox.Name = "ProgressEffectTextBox";
            this.ProgressEffectTextBox.Size = new System.Drawing.Size(141, 20);
            this.ProgressEffectTextBox.TabIndex = 14;
            this.ProgressEffectTextBox.TextChanged += new System.EventHandler(this.ProgressEffectTextBox_TextChanged);
            // 
            // TalentEffectTextBox
            // 
            this.TalentEffectTextBox.Location = new System.Drawing.Point(113, 46);
            this.TalentEffectTextBox.Name = "TalentEffectTextBox";
            this.TalentEffectTextBox.Size = new System.Drawing.Size(141, 20);
            this.TalentEffectTextBox.TabIndex = 13;
            this.TalentEffectTextBox.TextChanged += new System.EventHandler(this.TalentEffectTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(113, 20);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(141, 20);
            this.TitleTextBox.TabIndex = 12;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(260, 20);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(930, 20);
            this.textBox11.TabIndex = 11;
            this.textBox11.Text = "Event Description";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventDescriptionTextBox
            // 
            this.EventDescriptionTextBox.Location = new System.Drawing.Point(260, 46);
            this.EventDescriptionTextBox.Name = "EventDescriptionTextBox";
            this.EventDescriptionTextBox.Size = new System.Drawing.Size(930, 228);
            this.EventDescriptionTextBox.TabIndex = 10;
            this.EventDescriptionTextBox.Text = "";
            this.EventDescriptionTextBox.TextChanged += new System.EventHandler(this.EventDescriptionTextBox_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(7, 254);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "Tags to add";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(7, 228);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Valid Tags";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 202);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Valid Stages";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 176);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Min Roll";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Max roll";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Lifespan Effect";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Age effect";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Progress effect";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Talent Effect";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Event Title";
            // 
            // SaveEventFileButton
            // 
            this.SaveEventFileButton.Location = new System.Drawing.Point(12, 339);
            this.SaveEventFileButton.Name = "SaveEventFileButton";
            this.SaveEventFileButton.Size = new System.Drawing.Size(177, 23);
            this.SaveEventFileButton.TabIndex = 3;
            this.SaveEventFileButton.Text = "Save Event File";
            this.SaveEventFileButton.UseVisualStyleBackColor = true;
            this.SaveEventFileButton.Click += new System.EventHandler(this.SaveEventFileButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(12, 368);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(177, 23);
            this.AddEventButton.TabIndex = 4;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // StagesListBox
            // 
            this.StagesListBox.FormattingEnabled = true;
            this.StagesListBox.Location = new System.Drawing.Point(202, 309);
            this.StagesListBox.Name = "StagesListBox";
            this.StagesListBox.Size = new System.Drawing.Size(153, 160);
            this.StagesListBox.TabIndex = 5;
            this.StagesListBox.SelectedIndexChanged += new System.EventHandler(this.StagesListBox_SelectedIndexChanged);
            // 
            // StageFileSelectButton
            // 
            this.StageFileSelectButton.Location = new System.Drawing.Point(362, 310);
            this.StageFileSelectButton.Name = "StageFileSelectButton";
            this.StageFileSelectButton.Size = new System.Drawing.Size(114, 23);
            this.StageFileSelectButton.TabIndex = 6;
            this.StageFileSelectButton.Text = "Select Stage File";
            this.StageFileSelectButton.UseVisualStyleBackColor = true;
            this.StageFileSelectButton.Click += new System.EventHandler(this.StageFileSelectButton_Click);
            // 
            // SaveStageFileButton
            // 
            this.SaveStageFileButton.Location = new System.Drawing.Point(362, 339);
            this.SaveStageFileButton.Name = "SaveStageFileButton";
            this.SaveStageFileButton.Size = new System.Drawing.Size(114, 23);
            this.SaveStageFileButton.TabIndex = 7;
            this.SaveStageFileButton.Text = "Save Stage File";
            this.SaveStageFileButton.UseVisualStyleBackColor = true;
            this.SaveStageFileButton.Click += new System.EventHandler(this.SaveStageFileButton_Click);
            // 
            // AddStageButton
            // 
            this.AddStageButton.Location = new System.Drawing.Point(362, 368);
            this.AddStageButton.Name = "AddStageButton";
            this.AddStageButton.Size = new System.Drawing.Size(114, 23);
            this.AddStageButton.TabIndex = 8;
            this.AddStageButton.Text = "Add Stage File";
            this.AddStageButton.UseVisualStyleBackColor = true;
            this.AddStageButton.Click += new System.EventHandler(this.AddStageButton_Click);
            // 
            // RemoveEventButton
            // 
            this.RemoveEventButton.Location = new System.Drawing.Point(12, 397);
            this.RemoveEventButton.Name = "RemoveEventButton";
            this.RemoveEventButton.Size = new System.Drawing.Size(177, 23);
            this.RemoveEventButton.TabIndex = 9;
            this.RemoveEventButton.Text = "Remove Event";
            this.RemoveEventButton.UseVisualStyleBackColor = true;
            this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButton_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(362, 397);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(114, 20);
            this.textBox12.TabIndex = 22;
            this.textBox12.Text = "Stage Name";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(362, 423);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(114, 20);
            this.textBox13.TabIndex = 23;
            this.textBox13.Text = "Life Span";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(362, 449);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(114, 20);
            this.textBox14.TabIndex = 24;
            this.textBox14.Text = "Goal";
            // 
            // StageNameTextBox
            // 
            this.StageNameTextBox.Location = new System.Drawing.Point(482, 397);
            this.StageNameTextBox.Name = "StageNameTextBox";
            this.StageNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.StageNameTextBox.TabIndex = 22;
            this.StageNameTextBox.TextChanged += new System.EventHandler(this.StageNameTextBox_TextChanged);
            // 
            // LifeSpanTextBox
            // 
            this.LifeSpanTextBox.Location = new System.Drawing.Point(482, 423);
            this.LifeSpanTextBox.Name = "LifeSpanTextBox";
            this.LifeSpanTextBox.Size = new System.Drawing.Size(141, 20);
            this.LifeSpanTextBox.TabIndex = 25;
            this.LifeSpanTextBox.TextChanged += new System.EventHandler(this.LifeSpanTextBox_TextChanged);
            // 
            // GoalTextBox
            // 
            this.GoalTextBox.Location = new System.Drawing.Point(482, 449);
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.Size = new System.Drawing.Size(141, 20);
            this.GoalTextBox.TabIndex = 26;
            this.GoalTextBox.TextChanged += new System.EventHandler(this.GoalTextBox_TextChanged);
            // 
            // StageUpButton
            // 
            this.StageUpButton.Location = new System.Drawing.Point(482, 310);
            this.StageUpButton.Name = "StageUpButton";
            this.StageUpButton.Size = new System.Drawing.Size(141, 23);
            this.StageUpButton.TabIndex = 27;
            this.StageUpButton.Text = "Move Stage Up";
            this.StageUpButton.UseVisualStyleBackColor = true;
            this.StageUpButton.Click += new System.EventHandler(this.StageUpButton_Click);
            // 
            // StageDownButton
            // 
            this.StageDownButton.Location = new System.Drawing.Point(482, 339);
            this.StageDownButton.Name = "StageDownButton";
            this.StageDownButton.Size = new System.Drawing.Size(141, 23);
            this.StageDownButton.TabIndex = 28;
            this.StageDownButton.Text = "Move Stage Down";
            this.StageDownButton.UseVisualStyleBackColor = true;
            this.StageDownButton.Click += new System.EventHandler(this.StageDownButton_Click);
            // 
            // RemoveStageButton
            // 
            this.RemoveStageButton.Location = new System.Drawing.Point(482, 368);
            this.RemoveStageButton.Name = "RemoveStageButton";
            this.RemoveStageButton.Size = new System.Drawing.Size(141, 23);
            this.RemoveStageButton.TabIndex = 29;
            this.RemoveStageButton.Text = "Remove Stage";
            this.RemoveStageButton.UseVisualStyleBackColor = true;
            this.RemoveStageButton.Click += new System.EventHandler(this.RemoveStageButton_Click);
            // 
            // GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 482);
            this.Controls.Add(this.RemoveStageButton);
            this.Controls.Add(this.StageDownButton);
            this.Controls.Add(this.StageUpButton);
            this.Controls.Add(this.GoalTextBox);
            this.Controls.Add(this.LifeSpanTextBox);
            this.Controls.Add(this.StageNameTextBox);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.RemoveEventButton);
            this.Controls.Add(this.AddStageButton);
            this.Controls.Add(this.SaveStageFileButton);
            this.Controls.Add(this.StageFileSelectButton);
            this.Controls.Add(this.StagesListBox);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.SaveEventFileButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.EventSelectButton);
            this.Name = "GameEditor";
            this.Text = "Game Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EventSelectButton;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.RichTextBox EventDescriptionTextBox;
        private System.Windows.Forms.TextBox TagsToAddTextBox;
        private System.Windows.Forms.TextBox ValidTagsTextBox;
        private System.Windows.Forms.TextBox ValidStagesTextBox;
        private System.Windows.Forms.TextBox MinRollTextBox;
        private System.Windows.Forms.TextBox MaxRollTextBox;
        private System.Windows.Forms.TextBox LifespanEffectTextBox;
        private System.Windows.Forms.TextBox AgeEffectTextBox;
        private System.Windows.Forms.TextBox ProgressEffectTextBox;
        private System.Windows.Forms.TextBox TalentEffectTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button SaveEventFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.ListBox StagesListBox;
        private System.Windows.Forms.Button StageFileSelectButton;
        private System.Windows.Forms.Button SaveStageFileButton;
        private System.Windows.Forms.Button AddStageButton;
        private System.Windows.Forms.Button RemoveEventButton;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox StageNameTextBox;
        private System.Windows.Forms.TextBox LifeSpanTextBox;
        private System.Windows.Forms.TextBox GoalTextBox;
        private System.Windows.Forms.Button StageUpButton;
        private System.Windows.Forms.Button StageDownButton;
        private System.Windows.Forms.Button RemoveStageButton;
    }
}