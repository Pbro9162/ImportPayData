namespace ImportPayData
{
    partial class Form2
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
            notes_txtbox = new TextBox();
            notes_label = new Label();
            notes_clear_all_btn = new Button();
            notes_done_btn = new Button();
            notes_exit_btn = new Button();
            SuspendLayout();
            // 
            // notes_txtbox
            // 
            notes_txtbox.Location = new Point(48, 54);
            notes_txtbox.Multiline = true;
            notes_txtbox.Name = "notes_txtbox";
            notes_txtbox.Size = new Size(693, 337);
            notes_txtbox.TabIndex = 0;
            // 
            // notes_label
            // 
            notes_label.AutoSize = true;
            notes_label.Location = new Point(48, 21);
            notes_label.Name = "notes_label";
            notes_label.Size = new Size(144, 20);
            notes_label.TabIndex = 1;
            notes_label.Text = "Notes or Comments:";
            // 
            // notes_clear_all_btn
            // 
            notes_clear_all_btn.Location = new Point(445, 409);
            notes_clear_all_btn.Name = "notes_clear_all_btn";
            notes_clear_all_btn.Size = new Size(94, 29);
            notes_clear_all_btn.TabIndex = 2;
            notes_clear_all_btn.Text = "Clear All";
            notes_clear_all_btn.UseVisualStyleBackColor = true;
            notes_clear_all_btn.Click += notes_clear_all_btn_Click;
            // 
            // notes_done_btn
            // 
            notes_done_btn.Location = new Point(555, 408);
            notes_done_btn.Name = "notes_done_btn";
            notes_done_btn.Size = new Size(117, 29);
            notes_done_btn.TabIndex = 3;
            notes_done_btn.Text = "done/submit";
            notes_done_btn.UseVisualStyleBackColor = true;
            notes_done_btn.Click += notes_done_btn_Click;
            // 
            // notes_exit_btn
            // 
            notes_exit_btn.Location = new Point(685, 409);
            notes_exit_btn.Name = "notes_exit_btn";
            notes_exit_btn.Size = new Size(94, 29);
            notes_exit_btn.TabIndex = 4;
            notes_exit_btn.Text = "Exit";
            notes_exit_btn.UseVisualStyleBackColor = true;
            notes_exit_btn.Click += notes_exit_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notes_exit_btn);
            Controls.Add(notes_done_btn);
            Controls.Add(notes_clear_all_btn);
            Controls.Add(notes_label);
            Controls.Add(notes_txtbox);
            Name = "Form2";
            Text = "Notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox notes_txtbox;
        private Label notes_label;
        private Button notes_clear_all_btn;
        private Button notes_done_btn;
        private Button notes_exit_btn;
    }
}